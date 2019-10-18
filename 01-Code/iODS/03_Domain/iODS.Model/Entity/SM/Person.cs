using System;
using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 人员表
    /// </summary>
    [SugarTable("SM_Person")]
    public class Person : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true,ColumnName = "ID")]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string WorkNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DeptCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CorpCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Duty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsNullable = true)]
        public int? Position { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Superior { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsNullable = true)]
        public int? OrderNo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PersonStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DelFlag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsNullable = true)]
        public int? RandCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsNullable = false)]
        public DateTime LastPasswordChangeTime { get; set; }
    }
}