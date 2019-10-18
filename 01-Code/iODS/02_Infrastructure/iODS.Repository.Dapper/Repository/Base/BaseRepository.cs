using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;
using Hollysys.Common;
using iODS.Domain.Base;
using iODS.Model;

namespace iODS.Repository.Dapper
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity, new()
    {
        public async Task<bool> Add(T entity)
        {
           throw new NotImplementedException();
        }

        public async Task<bool> Add(T[] entities)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(object[] ids)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(T entity, string strWhere)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(T entity, List<string> columns = null, List<string> ignoreColumns = null, string strWhere = "")
        {
            throw new NotImplementedException();
        }

        public async Task<T> Query(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<T> Query(object id, bool isUseCache = false)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> Query(string[] ids)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> Query()
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> Query(string strWhere)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> Query(Expression<Func<T, bool>> whereExpression)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> Query(Expression<Func<T, bool>> whereExpression, string strOrderByFields)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> Query(Expression<Func<T, bool>> whereExpression, Expression<Func<T, object>> orderByExpression, bool isAsc = true)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> Query(string strWhere, string strOrderByFields)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> Query(Expression<Func<T, bool>> whereExpression, int intTop, string strOrderByFields)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> Query(string strWhere, int intTop, string strOrderByFields)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> Query(Expression<Func<T, bool>> whereExpression, int intPageIndex, int intPageSize, string strOrderByFields)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> Query(string strWhere, int intPageIndex, int intPageSize, string strOrderByFields)
        {
            throw new NotImplementedException();
        }

        public async Task<PageResult<T>> QueryPage(Expression<Func<T, bool>> whereExpression, int intPageIndex = 1, int intPageSize = 20, string strOrderByFields = null)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TResult>> QueryMuch<T1, T2, T3, TResult>(Expression<Func<T1, T2, T3, object[]>> joinExpression, Expression<Func<T1, T2, T3, TResult>> selectExpression,
                                                         Expression<Func<T1, T2, T3, bool>> whereLambda = null) where T1 : class, new()
        {
            throw new NotImplementedException();
        }

        private static string GetTableName(T entity)
        {
            string tableName;
            Type type =entity.GetType();
            if (type.IsClass && !type.IsInterface&&type.GetCustomAttributes().FirstOrDefault(x =>
                        x.GetType() == typeof(TableAttribute)) is TableAttribute attribute)
            {
                
                     tableName = attribute.Name;
                
            }
            else
            {
                throw new ArgumentException(nameof(entity)+"No added TableAttribute to database mapping");
            }

            return tableName;
        }
    }
}