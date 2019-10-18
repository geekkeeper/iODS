using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Hollysys.Common;
using iODS.Model;

namespace iODS.Domain.Base
{
    public interface IBaseRepository<T> where T : BaseEntity, new()
    {
        #region 添加

        /// <summary>
        ///     添加单个
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns>true:成功，false失败</returns>
        Task<bool> Add(T entity);

        /// <summary>
        ///     批量添加
        /// </summary>
        /// <param name="entities">实体集合</param>
        /// <returns>true:成功，false失败</returns>
        Task<bool> Add(T[] entities);

        #endregion 添加

        #region 删除

        /// <summary>
        ///     物理删除：删除单个
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <returns>true:成功，false失败</returns>
        Task<bool> Delete(object id);

        /// <summary>
        ///     物理删除：删除单个
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns>true:成功，false失败</returns>
        Task<bool> Delete(T entity);

        /// <summary>
        ///     批量删除
        /// </summary>
        /// <param name="ids">主键ID集合</param>
        /// <returns>true:成功，false失败</returns>
        Task<bool> Delete(object[] ids);

        #endregion 删除

        #region 更新

        /// <summary>
        ///     更新
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns>true:成功，false失败</returns>
        Task<bool> Update(T entity);

        /// <summary>
        ///     更新
        /// </summary>
        /// <param name="entity">实体</param>
        /// <param name="strWhere">更新条件</param>
        /// <returns>true:成功，false失败</returns>
        Task<bool> Update(T entity, string strWhere);

        /// <summary>
        ///     更新
        /// </summary>
        /// <param name="entity">实体</param>
        /// <param name="columns">更新的列</param>
        /// <param name="ignoreColumns">忽略的列</param>
        /// <param name="strWhere">更新条件</param>
        /// <returns>true:成功，false失败</returns>
        Task<bool> Update(T entity, List<string> columns = null, List<string> ignoreColumns = null,
                          string strWhere = "");

        #endregion 更新

        #region 查询

        /// <summary>
        ///     查询单个
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <returns>实体</returns>
        Task<T> Query(object id);

        /// <summary>
        ///     查询单个：是否使用缓存
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <param name="isUseCache">是否使用缓存</param>
        /// <returns>实体</returns>
        Task<T> Query(object id, bool isUseCache = false);

        /// <summary>
        ///     批量查询
        /// </summary>
        /// <param name="ids">主键ID集合</param>
        /// <returns>实体集合</returns>
        Task<List<T>> Query(string[] ids);

        /// <summary>
        ///     查询所有
        /// </summary>
        /// <returns></returns>
        Task<List<T>> Query();

        /// <summary>
        ///     查询多个：where条件
        /// </summary>
        /// <param name="strWhere">where条件</param>
        /// <returns>实体集合</returns>
        Task<List<T>> Query(string strWhere);

        /// <summary>
        ///     查询多个：条件表达式
        /// </summary>
        /// <param name="whereExpression">条件表达式</param>
        /// <returns></returns>
        Task<List<T>> Query(Expression<Func<T, bool>> whereExpression);

        /// <summary>
        ///     查询多个：1.条件表达式；2.排序字段
        /// </summary>
        /// <param name="whereExpression">条件表达式</param>
        /// <param name="strOrderByFields">排序字段</param>
        /// <returns></returns>
        Task<List<T>> Query(Expression<Func<T, bool>> whereExpression, string strOrderByFields);

        /// <summary>
        ///     查询多个：1.条件表达式；2.排序表达式
        /// </summary>
        /// <param name="whereExpression">条件表达式</param>
        /// <param name="orderByExpression">排序表达式</param>
        /// <param name="isAsc">是否升序</param>
        /// <returns></returns>
        Task<List<T>> Query(Expression<Func<T, bool>> whereExpression,
                            Expression<Func<T, object>> orderByExpression, bool isAsc = true);

        /// <summary>
        ///     查询多个：1.where条件；2.排序字段
        /// </summary>
        /// <param name="strWhere">where条件</param>
        /// <param name="strOrderByFields">排序字段</param>
        /// <returns>实体集合</returns>
        Task<List<T>> Query(string strWhere, string strOrderByFields);

        /// <summary>
        ///     查询多个：1.条件表达式；2.查询上限；3.排序字段
        /// </summary>
        /// <param name="whereExpression">条件表达式</param>
        /// <param name="intTop">查询上限</param>
        /// <param name="strOrderByFields">排序字段</param>
        /// <returns>实体集合</returns>
        Task<List<T>> Query(Expression<Func<T, bool>> whereExpression, int intTop, string strOrderByFields);

        /// <summary>
        ///     查询多个：1.where条件；2.查询上限；3.排序字段
        /// </summary>
        /// <param name="strWhere">where条件</param>
        /// <param name="intTop">查询上限</param>
        /// <param name="strOrderByFields">排序字段</param>
        /// <returns></returns>
        Task<List<T>> Query(string strWhere, int intTop, string strOrderByFields);

        /// <summary>
        ///     分页查询：1.条件表达式；2.分页索引；3.分页大小；4.排序字段
        /// </summary>
        /// <param name="whereExpression">条件表达式</param>
        /// <param name="intPageIndex">分页索引</param>
        /// <param name="intPageSize">分页大小</param>
        /// <param name="strOrderByFields">排序字段</param>
        /// <returns></returns>
        Task<List<T>> Query(
                Expression<Func<T, bool>> whereExpression, int intPageIndex, int intPageSize,
                string strOrderByFields);

        /// <summary>
        ///     分页查询：1.where条件；2.分页索引；3.分页大小；4.排序字段
        /// </summary>
        /// <param name="strWhere">where条件</param>
        /// <param name="intPageIndex">分页索引</param>
        /// <param name="intPageSize">分页大小</param>
        /// <param name="strOrderByFields">排序字段</param>
        /// <returns></returns>
        Task<List<T>> Query(string strWhere, int intPageIndex, int intPageSize, string strOrderByFields);

        /// <summary>
        ///     分页查询：1.条件表达式；2.分页索引；3.分页大小；4.排序字段
        /// </summary>
        /// <param name="whereExpression">条件表达式</param>
        /// <param name="intPageIndex">分页索引</param>
        /// <param name="intPageSize">分页大小</param>
        /// <param name="strOrderByFields">排序字段</param>
        /// <returns></returns>
        Task<PageResult<T>> QueryPage(Expression<Func<T, bool>> whereExpression, int intPageIndex = 1,
                                      int intPageSize = 20, string strOrderByFields = null);

        /// <summary>
        ///     多表查询
        /// </summary>
        /// <param name="joinExpression">联合表达式</param>
        /// <param name="selectExpression">选择表达式</param>
        /// <param name="whereLambda"></param>
        /// <typeparam name="T1">表1实体</typeparam>
        /// <typeparam name="T2">表2实体</typeparam>
        /// <typeparam name="T3">表3实体</typeparam>
        /// <typeparam name="TResult">返回的实体类型</typeparam>
        /// <returns></returns>
        Task<List<TResult>> QueryMuch<T1, T2, T3, TResult>(
                Expression<Func<T1, T2, T3, object[]>> joinExpression,
                Expression<Func<T1, T2, T3, TResult>> selectExpression,
                Expression<Func<T1, T2, T3, bool>> whereLambda = null) where T1 : class, new();

        #endregion 查询
    }
}