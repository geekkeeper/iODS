using System;

namespace DatabaseUpdate.Entity
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class User
    {
        /// <summary>
        /// 用户ID 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 账户
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// 微信账号
        /// </summary>
        public string WechatId { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 职位
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int? Age { get; set; }

        /// <summary>
        /// 性别;M-男,F-女,U-未知
        /// </summary>
        public Sex Sex { get; set; }

        /// <summary>
        /// 学历
        /// </summary>
        public EducationBackground Education { get; set; }

        /// <summary>
        /// 照片地址
        /// </summary>
        public string PictureUrl { get; set; }

        /// <summary>
        /// 国籍/民族
        /// </summary>
        public string Nationality { get; set; }

        /// <summary>
        /// 大学
        /// </summary>
        public string University { get; set; }

        /// <summary>
        /// 加入时间
        /// </summary>
        public DateTime? EntryTime { get; set; }

        /// <summary>
        /// 住址
        /// </summary>
        public string Place { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }

        public IdType IdType { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        public string IdNumber { get; set; }

        /// <summary>
        /// 政治面貌
        /// </summary>
        public PoliticsStatus PoliticsStatus { get; set; }

        /// <summary>
        /// 工作年限
        /// </summary>
        public string WorkingYears { get; set; }

        /// <summary>
        /// 在职状态:1-在职,0-离职
        /// </summary>
        public WorkingState WorkingState { get; set; }

        /// <summary>
        /// 工资卡
        /// </summary>
        public string WageCard { get; set; }

        /// <summary>
        /// 开户行
        /// </summary>
        public string OpeningBank { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public string UpdatedBy { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? UpdatedTime { get; set; }
    }

    public enum WorkingState
    {
        /// <summary>
        /// 在职
        /// </summary>
        Incumbency,

        /// <summary>
        /// 离职
        /// </summary>
        Dimission
    }

    /// <summary>
    /// 政治面貌
    /// </summary>
    public enum PoliticsStatus
    {
        /// <summary>
        /// 群众
        /// </summary>
        Masses,

        /// <summary>
        /// 党员
        /// </summary>
        PartyMember,

        /// <summary>
        /// 团员
        /// </summary>
        LeagueMember,

        /// <summary>
        /// 其他
        /// </summary>
        Other
    }

    /// <summary>
    /// 证件类型
    /// </summary>
    public enum IdType
    {
        /// <summary>
        /// 居民户口簿
        /// </summary>
        HouseholdRegister,

        /// <summary>
        /// 居民身份证
        /// </summary>
        IDCard,

        /// <summary>
        /// 护照
        /// </summary>
        Passport,

        /// <summary>
        /// 出入境通行证
        /// </summary>
        GatePass,

        /// <summary>
        /// 现役军官证
        /// </summary>
        MilitaryCard,

        /// <summary>
        /// 现役士官证
        /// </summary>
        SergeantCard,

        /// <summary>
        /// 现役士兵证
        /// </summary>
        SoldierCard,

        /// <summary>
        /// 社会保障卡
        /// </summary>
        SinCard
    }

    /// <summary>
    /// 教育背景
    /// </summary>
    public enum EducationBackground
    {
        /// <summary>
        /// 小学
        /// </summary>
        Primary,

        /// <summary>
        /// 初中
        /// </summary>
        Junior,

        /// <summary>
        /// 高中
        /// </summary>
        Senior,

        /// <summary>
        /// 大专
        /// </summary>
        College,

        /// <summary>
        /// 本科
        /// </summary>
        Bachelor,

        /// <summary>
        /// 硕士
        /// </summary>
        Master,

        /// <summary>
        /// 博士
        /// </summary>
        Doctor,

        /// <summary>
        /// 博士后
        /// </summary>
        PostDoctor
    }

    public enum Sex
    {
        /// <summary>
        /// 女
        /// </summary>
        Female,

        /// <summary>
        /// 男
        /// </summary>
        Male
    }
}