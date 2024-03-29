﻿using System.Collections.Generic;

namespace Hollysys.Common
{
    /// <summary>
    ///     分页返回类
    /// </summary>
    /// <typeparam name="T">实体</typeparam>
    public class PageResult<T>
    {
        /// <summary>
        ///     当前页码
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        ///     每页条数
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        ///     数据总数
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        ///     总页数
        /// </summary>
        public int TotalPages { get; set; }

        /// <summary>
        ///     元素集合
        /// </summary>
        public List<T> Data { get; set; }
    }
}