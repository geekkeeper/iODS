using System;

namespace DatabaseUpdate.Annotation.Common
{
    public class UsingNameAttribute:Attribute
    {
        public UsingNameAttribute(string usingName)
        {
            this.UsingName = usingName;
        }

        /// <summary>
        /// 现用名
        /// </summary>
        public string UsingName { get; }
    }
}