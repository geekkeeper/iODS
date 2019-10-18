using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Hollysys.Common;
using Hollysys.Common.Attribute;
using iODS.Domain.Base;
using iODS.Model;
using SqlSugar;

namespace iODS.Repository.SQLSugar
{

    [Repository]
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity, new()
    {
        protected BaseRepository()
        {
            DbContext.Init(DatabaseConfig.ConnectionString, (DbType) DatabaseConfig.DataBaseType);
            this.Context      = DbContext.GetDbContext();
            this.SugarClient  = this.Context.SugarClient;
            this.SimpleClient = DbContext.GetEntityDb<T>(this.SugarClient);
        }

        private   DbContext       Context      { get; }
        protected SimpleClient<T> SimpleClient { get; }
        protected SqlSugarClient  SugarClient  { get; }

        #region 添加

        /// <summary>
        ///     添加单个
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns>主键ID</returns>
        public virtual async Task<bool> Add(T entity)
        {
            IInsertable<T> insert = this.SugarClient.Insertable(entity);
            return await insert.ExecuteCommandIdentityIntoEntityAsync();
        }

        /// <summary>
        ///     批量添加
        /// </summary>
        /// <param name="entities">实体集合</param>
        /// <returns>影响行数</returns>
        public virtual async Task<bool> Add(T[] entities)
        {
            return await this.SugarClient.Insertable(entities).ExecuteCommandIdentityIntoEntityAsync();
        }

        #endregion 添加

        #region 删除

        /// <summary>
        ///     物理删除：删除单个
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <returns></returns>
        public virtual async Task<bool> Delete(object id)
        {
            return await this.SugarClient.Deleteable<T>(id).ExecuteCommandHasChangeAsync();
        }

        /// <summary>
        ///     物理删除：删除单个
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public virtual async Task<bool> Delete(T entity)
        {
            return await this.SugarClient.Deleteable(entity).ExecuteCommandHasChangeAsync();
        }

        /// <summary>
        ///     批量删除
        /// </summary>
        /// <param name="ids">主键ID集合</param>
        /// <returns></returns>
        public virtual async Task<bool> Delete(object[] ids)
        {
            return await this.SugarClient.Deleteable<T>().In(ids).ExecuteCommandHasChangeAsync();
        }

        #endregion 删除

        #region 更新

        /// <summary>
        ///     更新
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public virtual async Task<bool> Update(T entity)
        {
            return await this.SugarClient.Updateable(entity).ExecuteCommandHasChangeAsync();
        }

        /// <summary>
        ///     更新
        /// </summary>
        /// <param name="entity">实体</param>
        /// <param name="strWhere">更新条件</param>
        /// <returns></returns>
        public virtual async Task<bool> Update(T entity, string strWhere)
        {
            return await this.SugarClient.Updateable(entity).Where(strWhere).ExecuteCommandHasChangeAsync();
        }

        /// <summary>
        ///     更新
        /// </summary>
        /// <param name="entity">实体</param>
        /// <param name="columns">更新的列</param>
        /// <param name="ignoreColumns">忽略的列</param>
        /// <param name="strWhere">更新条件</param>
        /// <returns></returns>
        public virtual async Task<bool> Update(T entity, List<string> columns = null, List<string> ignoreColumns = null,
                                       string strWhere = "")
        {
            IUpdateable<T> updateable = this.SugarClient.Updateable(entity);
            if (ignoreColumns != null && ignoreColumns.Count > 0)
            {
                updateable = updateable.IgnoreColumns(ignoreColumns.ToArray());
            }

            if (columns != null && columns.Count > 0)
            {
                updateable = updateable.UpdateColumns(columns.ToArray());
            }

            if (!string.IsNullOrEmpty(strWhere))
            {
                updateable = updateable.Where(strWhere);
            }

            return await updateable.ExecuteCommandHasChangeAsync();
        }

        #endregion 更新

        #region 查询

        /// <summary>
        ///     查询单个
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <returns>实体</returns>
        public virtual async Task<T> Query(object id)
        {
            return await this.SugarClient.Queryable<T>().In(id).SingleAsync();
        }

        /// <summary>
        ///     查询单个：是否使用缓存
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <param name="isUseCache">是否使用缓存</param>
        /// <returns>实体</returns>
        public virtual async Task<T> Query(object id, bool isUseCache = false)
        {
            return await this.SugarClient.Queryable<T>().WithCacheIF(isUseCache).In(id).SingleAsync();
        }

        /// <summary>
        ///     批量查询
        /// </summary>
        /// <param name="ids">主键ID集合</param>
        /// <returns>实体集合</returns>
        public virtual async Task<List<T>> Query(string[] ids)
        {
            return await this.SugarClient.Queryable<T>().In(ids).ToListAsync();
        }

        /// <summary>
        ///     查询所有
        /// </summary>
        /// <returns></returns>
        public virtual async Task<List<T>> Query()
        {
            return await this.SugarClient.Queryable<T>().ToListAsync();
        }

        /// <summary>
        ///     查询多个：where条件
        /// </summary>
        /// <param name="strWhere">where条件</param>
        /// <returns>实体集合</returns>
        public virtual async Task<List<T>> Query(string strWhere)
        {
            return await this.SugarClient.Queryable<T>().WhereIF(!string.IsNullOrEmpty(strWhere), strWhere)
                             .ToListAsync();
        }

        /// <summary>
        ///     查询多个：条件表达式
        /// </summary>
        /// <param name="whereExpression">条件表达式</param>
        /// <returns></returns>
        public virtual async Task<List<T>> Query(Expression<Func<T, bool>> whereExpression)
        {
            return await this.SugarClient.Queryable<T>().WhereIF(whereExpression != null, whereExpression)
                             .ToListAsync();
        }

        /// <summary>
        ///     查询多个：1.条件表达式；2.排序字段
        /// </summary>
        /// <param name="whereExpression">条件表达式</param>
        /// <param name="strOrderByFields">排序字段</param>
        /// <returns></returns>
        public virtual async Task<List<T>> Query(Expression<Func<T, bool>> whereExpression, string strOrderByFields)
        {
            return await this.SugarClient.Queryable<T>().WhereIF(whereExpression != null, whereExpression)
                             .OrderByIF(!string.IsNullOrEmpty(strOrderByFields), strOrderByFields).ToListAsync();
        }

        /// <summary>
        ///     查询多个：1.条件表达式；2.排序表达式;3.是否升序
        /// </summary>
        /// <param name="whereExpression">条件表达式</param>
        /// <param name="orderByExpression">排序表达式</param>
        /// <param name="isAsc">是否升序</param>
        /// <returns></returns>
        public virtual async Task<List<T>> Query(Expression<Func<T, bool>> whereExpression,
                                         Expression<Func<T, object>> orderByExpression, bool isAsc = true)
        {
            return await this.SugarClient.Queryable<T>().WhereIF(whereExpression != null, whereExpression)
                             .OrderByIF(orderByExpression != null, orderByExpression,
                                     isAsc ? OrderByType.Asc : OrderByType.Desc).ToListAsync();
        }

        /// <summary>
        ///     查询多个：1.where条件；2.排序字段
        /// </summary>
        /// <param name="strWhere">where条件</param>
        /// <param name="strOrderByFields">排序字段</param>
        /// <returns>实体集合</returns>
        public virtual async Task<List<T>> Query(string strWhere, string strOrderByFields)
        {
            return await this.SugarClient.Queryable<T>()
                             .OrderByIF(!string.IsNullOrEmpty(strOrderByFields), strOrderByFields)
                             .WhereIF(!string.IsNullOrEmpty(strWhere), strWhere).ToListAsync();
        }

        /// <summary>
        ///     查询多个：1.条件表达式；2.查询上限；3.排序字段
        /// </summary>
        /// <param name="whereExpression">条件表达式</param>
        /// <param name="intTop">查询上限</param>
        /// <param name="strOrderByFields">排序字段</param>
        /// <returns>实体集合</returns>
        public virtual async Task<List<T>> Query(Expression<Func<T, bool>> whereExpression, int intTop, string strOrderByFields)
        {
            return await this.SugarClient.Queryable<T>()
                             .OrderByIF(!string.IsNullOrEmpty(strOrderByFields), strOrderByFields)
                             .WhereIF(whereExpression != null, whereExpression).Take(intTop).ToListAsync();
        }

        /// <summary>
        ///     查询多个：1.where条件；2.查询上限；3.排序字段
        /// </summary>
        /// <param name="strWhere">where条件</param>
        /// <param name="intTop">查询上限</param>
        /// <param name="strOrderByFields">排序字段</param>
        /// <returns></returns>
        public virtual async Task<List<T>> Query(string strWhere, int intTop, string strOrderByFields)
        {
            return await this.SugarClient.Queryable<T>()
                             .OrderByIF(!string.IsNullOrEmpty(strOrderByFields), strOrderByFields)
                             .WhereIF(!string.IsNullOrEmpty(strWhere), strWhere).Take(intTop).ToListAsync();
        }

        /// <summary>
        ///     分页查询：1.条件表达式；2.分页索引；3.分页大小；4.排序字段
        /// </summary>
        /// <param name="whereExpression">条件表达式</param>
        /// <param name="intPageIndex">分页索引</param>
        /// <param name="intPageSize">分页大小</param>
        /// <param name="strOrderByFields">排序字段</param>
        /// <returns></returns>
        public virtual async Task<List<T>> Query(
                Expression<Func<T, bool>> whereExpression, int intPageIndex, int intPageSize,
                string strOrderByFields)
        {
            return await this.SugarClient.Queryable<T>()
                             .OrderByIF(!string.IsNullOrEmpty(strOrderByFields), strOrderByFields)
                             .WhereIF(whereExpression != null, whereExpression)
                             .ToPageListAsync(intPageIndex, intPageSize);
        }

        /// <summary>
        ///     分页查询：1.where条件；2.分页索引；3.分页大小；4.排序字段
        /// </summary>
        /// <param name="strWhere">where条件</param>
        /// <param name="intPageIndex">分页索引</param>
        /// <param name="intPageSize">分页大小</param>
        /// <param name="strOrderByFields">排序字段</param>
        /// <returns></returns>
        public virtual async Task<List<T>> Query(string strWhere, int intPageIndex, int intPageSize, string strOrderByFields)
        {
            return await this.SugarClient.Queryable<T>()
                             .OrderByIF(!string.IsNullOrEmpty(strOrderByFields), strOrderByFields)
                             .WhereIF(!string.IsNullOrEmpty(strWhere), strWhere)
                             .ToPageListAsync(intPageIndex, intPageSize);
        }

        /// <summary>
        ///     分页查询：1.条件表达式；2.分页索引；3.分页大小；4.排序字段
        /// </summary>
        /// <param name="whereExpression">条件表达式</param>
        /// <param name="intPageIndex">分页索引</param>
        /// <param name="intPageSize">分页大小</param>
        /// <param name="strOrderByFields">排序字段</param>
        /// <returns></returns>
        public virtual async Task<PageResult<T>> QueryPage(Expression<Func<T, bool>> whereExpression, int intPageIndex = 1,
                                                   int intPageSize = 20, string strOrderByFields = null)
        {
            RefAsync<int> totalCount = 0;
            List<T> list = await this.SugarClient.Queryable<T>()
                                     .OrderByIF(!string.IsNullOrEmpty(strOrderByFields), strOrderByFields)
                                     .WhereIF(whereExpression != null, whereExpression)
                                     .ToPageListAsync(intPageIndex, intPageSize, totalCount);
            int pageCount = ConverterHelper.ObjToInt(
                    Math.Ceiling(ConverterHelper.ObjToDecimal(totalCount) / ConverterHelper.ObjToDecimal(intPageSize)));

            return new PageResult<T>
            {
                    TotalCount = totalCount, TotalPages = pageCount, PageIndex = intPageIndex, PageSize = intPageSize,
                    Data       = list
            };
        }

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
        public virtual async Task<List<TResult>> QueryMuch<T1, T2, T3, TResult>(
                Expression<Func<T1, T2, T3, object[]>> joinExpression,
                Expression<Func<T1, T2, T3, TResult>> selectExpression,
                Expression<Func<T1, T2, T3, bool>> whereLambda = null) where T1 : class, new()
        {
            return await this.SugarClient.Queryable(joinExpression).WhereIF(whereLambda != null, whereLambda)
                             .Select(selectExpression).ToListAsync();
        }

        #endregion 查询
    }
}