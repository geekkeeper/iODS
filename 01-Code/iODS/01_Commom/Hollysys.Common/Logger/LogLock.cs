using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using Microsoft.AspNetCore.Hosting;

namespace Hollysys.Common
{
    /// <summary>
    ///     日志锁
    /// </summary>
    public class LogLock
    {
        private static readonly ReaderWriterLockSlim LockSlim     = new ReaderWriterLockSlim();
        private static          string               _contentRoot = string.Empty;

        public LogLock(IWebHostEnvironment environment)
        {
            _contentRoot = environment.ContentRootPath;
        }

        public static void OutSql2Log(string fileName, string[] dataParas)
        {
            try
            {
                //设置读写锁为写入模式独占资源，其他写入请求需要等待本次写入结束之后才能继续写入
                //注意：长时间持有读线程锁或写线程锁会使其他线程发生饥饿 (starve)。 为了得到最好的性能，需要考虑重新构造应用程序以将写访问的持续时间减少到最小。
                //从性能方面考虑，请求进入写入模式应该紧跟文件操作之前，在此处进入写入模式仅是为了降低代码复杂度
                //因进入与退出写入模式应在同一个try finally语句块内，所以在请求进入写入模式之前不能触发异常，否则释放次数大于请求次数将会触发异常
                LockSlim.EnterWriteLock();
                string path = _contentRoot + @"\Log";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                string logFilePath = path + $@"\{fileName}.log";
                string logContent = "--------------------------------\r\n" +
                                    DateTime.Now + "|\r\n" +
                                    string.Join("\r\n", dataParas) + "\r\n";
                File.AppendAllText(logFilePath, logContent);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                //退出写入模式，释放资源占用
                //注意：一次请求对应一次释放
                //若释放次数大于请求次数将会触发异常[写入锁定未经保持即被释放]
                //若请求处理完成后未释放将会触发异常[此模式不下允许以递归方式获取写入锁定]
                LockSlim.ExitWriteLock();
            }
        }

        public static string ReadLog(string path, Encoding encoding)
        {
            string       result       = string.Empty;
            StreamReader streamReader = null;

            try
            {
                LockSlim.EnterReadLock();
                if (!File.Exists(path))
                {
                    return result;
                }
                else
                {
                    streamReader = new StreamReader(path, encoding);
                    result       = streamReader.ReadToEnd();
                }
            }
            catch (Exception)
            {
                //TODO:
            }
            finally
            {
                streamReader?.Close();
                streamReader?.Dispose();
                LockSlim.ExitReadLock();
            }

            return result;
        }

        public static List<LogInfo> GetLogData()
        {
            var aopLogs     = new List<LogInfo>();
            var excLogs     = new List<LogInfo>();
            var sqlLogs     = new List<LogInfo>();
            var requestLogs = new List<LogInfo>();
            try
            {
                aopLogs = ReadLog(Path.Combine(_contentRoot, "Log", "AOPLog.log"), Encoding.UTF8)
                          .Split("--------------------------------")
                          .Where(d => !string.IsNullOrEmpty(d) && d != "\n" && d != "\r\n")
                          .Select(d => new LogInfo
                          {
                                  Datetime = d.Split("|")[0].ObjToDate(),
                                  Content  = d.Split("|")[1]?.Replace("\r\n", "<br>"),
                                  LogColor = "AOP"
                          }).ToList();
            }
            catch (Exception)
            {
                // ignored
            }

            try
            {
                excLogs = ReadLog(Path.Combine(_contentRoot, "Log", $"GlobalExceptionLogs_{DateTime.Now:yyyMMdd}.log"),
                                  Encoding.UTF8)?
                          .Split("--------------------------------")
                          .Where(d => !string.IsNullOrEmpty(d) && d != "\n" && d != "\r\n")
                          .Select(d => new LogInfo
                          {
                                  Datetime = d.Split("|")[0].Split(',')[0].ObjToDate(),
                                  Content  = d.Split("|")[1]?.Replace("\r\n", "<br>"),
                                  LogColor = "EXC",
                                  Import   = 9
                          }).ToList();
            }
            catch (Exception)
            {
                //
            }

            try
            {
                sqlLogs = ReadLog(Path.Combine(_contentRoot, "Log", "SqlLog.log"), Encoding.UTF8)
                          .Split("--------------------------------")
                          .Where(d => !string.IsNullOrEmpty(d) && d != "\n" && d != "\r\n")
                          .Select(d => new LogInfo
                          {
                                  Datetime = d.Split("|")[0].ObjToDate(),
                                  Content  = d.Split("|")[1]?.Replace("\r\n", "<br>"),
                                  LogColor = "SQL"
                          }).ToList();
            }
            catch (Exception)
            {
                //
            }

            try
            {
                requestLogs = ReadLog(Path.Combine(_contentRoot, "Log", "RequestResponseLog.log"), Encoding.UTF8)
                              .Split("--------------------------------")
                              .Where(d => !string.IsNullOrEmpty(d) && d != "\n" && d != "\r\n")
                              .Select(d => new LogInfo
                              {
                                      Datetime = d.Split("|")[0].ObjToDate(),
                                      Content  = d.Split("|")[1]?.Replace("\r\n", "<br>"),
                                      LogColor = "ReqRes"
                              }).ToList();
            }
            catch (Exception)
            {
                //
            }

            aopLogs.AddRange(excLogs);
            aopLogs.AddRange(sqlLogs);
            aopLogs.AddRange(requestLogs);
            aopLogs = aopLogs.OrderByDescending(d => d.Import).ThenByDescending(d => d.Datetime).Take(100).ToList();

            return aopLogs;
        }
    }

    public class LogInfo
    {
        /// <summary>
        ///     时间
        /// </summary>
        public DateTime Datetime { get; set; }

        /// <summary>
        ///     内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        ///     IP
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        ///     日志颜色
        /// </summary>
        public string LogColor { get; set; }

        /// <summary>
        ///     重要性
        /// </summary>
        public int Import { get; set; }
    }
}