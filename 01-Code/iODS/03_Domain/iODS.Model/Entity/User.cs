using System;
using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    ///     用户表
    /// </summary>
    [SugarTable("user")]
    public class User : BaseEntity
    {
        private int? _age;

        private DateTime? _createdTime;

        private DateTime? _joinedTime;

        private DateTime? _updatedTime;

        /// <summary>
        ///     用户ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string Id { get; set; }

        /// <summary>
        ///     部门ID
        /// </summary>
        public string DeptId { get; set; }

        /// <summary>
        ///     微信账号
        /// </summary>
        public string WechatId { get; set; }

        /// <summary>
        ///     用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        ///     密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        ///     职位
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        ///     年龄
        /// </summary>
        public int? Age
        {
            get => this._age;
            set => this._age = value ?? default;
        }

        /// <summary>
        ///     性别;M-男,F-女,U-未知
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        ///     学历
        /// </summary>
        public string Education { get; set; }

        /// <summary>
        ///     图片
        /// </summary>
        public string Picture { get; set; }

        /// <summary>
        ///     国籍/民族
        /// </summary>
        public string Nationality { get; set; }

        /// <summary>
        ///     大学
        /// </summary>
        public string University { get; set; }

        /// <summary>
        ///     加入时间
        /// </summary>
        public DateTime? JoinedTime
        {
            get => this._joinedTime;
            set => this._joinedTime = value ?? default;
        }

        /// <summary>
        ///     住址
        /// </summary>
        public string Place { get; set; }

        /// <summary>
        ///     地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        ///     电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        ///     邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        ///     身份证号码
        /// </summary>
        public string CardId { get; set; }

        /// <summary>
        ///     政治面貌
        /// </summary>
        public string PoliticalType { get; set; }

        /// <summary>
        ///     工作年限
        /// </summary>
        public string WorkingYears { get; set; }

        /// <summary>
        ///     在职状态:1-在职,0-离职
        /// </summary>
        public string State { get; set; }

        /// <summary>
        ///     工资卡
        /// </summary>
        public string WageCard { get; set; }

        /// <summary>
        ///     文件
        /// </summary>
        public string Files { get; set; }

        /// <summary>
        ///     开户行
        /// </summary>
        public string OpeningBank { get; set; }

        /// <summary>
        ///     津贴
        /// </summary>
        public string Perdiem { get; set; }

        /// <summary>
        ///     创建时间
        /// </summary>
        public DateTime? CreatedTime
        {
            get => this._createdTime;
            set => this._createdTime = value ?? default;
        }

        /// <summary>
        ///     创建人
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        ///     修改时间
        /// </summary>
        public DateTime? UpdatedTime
        {
            get => this._updatedTime;
            set => this._updatedTime = value ?? default;
        }

        /// <summary>
        ///     修改人
        /// </summary>
        public string UpdatedBy { get; set; }

        /// <summary>
        ///     是否超级管理员:是-Y,否-N
        /// </summary>
        public string IsSuperAdmin { get; set; }
    }
}