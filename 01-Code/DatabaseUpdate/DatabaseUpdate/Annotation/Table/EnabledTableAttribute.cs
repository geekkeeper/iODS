using System;

namespace DatabaseUpdate.Annotation.Table
{
    /// <summary>
    /// 是否启用该表
    /// </summary>
    public class EnabledTableAttribute:Attribute
    {
        /// <summary>
        /// 是否启用该表:true：启用，false：不启用
        /// </summary>
        public bool IsEnable { get; }

        public EnabledTableAttribute()
        {
            this.IsEnable = true;
        }

        /// <summary>
        /// 是否启用该表:true：启用，false：不启用
        /// </summary>
        /// <param name="isEnable"></param>
        public EnabledTableAttribute(bool isEnable)
        {
            this.IsEnable = isEnable;
        }
    }
}