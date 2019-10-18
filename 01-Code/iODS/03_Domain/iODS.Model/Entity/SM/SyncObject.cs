using System;
using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 手机APP同步表
    /// </summary>
    [SugarTable("SM_SyncObject")]
    public class SyncObject : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "strObjectName")]
        public string ObjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "nStatus")]
        public int? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "dtLastLockTime")]
        public DateTime? LastLockTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "dtLastUnlockTime")]
        public DateTime? LastUnlockTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "ts")]
        public byte[] ts { get; set; }
    }
}