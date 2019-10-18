using System;

namespace DatabaseUpdate.Annotation.Common
{
    /// <summary>
    /// 曾用名特性：用于更新数据库、表、字段
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Field | AttributeTargets.Property,AllowMultiple = true,Inherited = false)]
    public class UsedNameAttribute:Attribute
    {
        public UsedNameAttribute(string usedName)
        {
            this.UsedName = usedName;
        }

        /// <summary>
        /// 曾用名
        /// </summary>
        public string UsedName { get; }
    }
}