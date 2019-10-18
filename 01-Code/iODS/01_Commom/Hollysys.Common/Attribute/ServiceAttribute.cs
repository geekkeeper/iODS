using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Hollysys.Common.Attribute
{
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class)]
    public class ServiceAttribute:System.Attribute,IFilterMetadata
    {
        public Type InterfaceType { get; }

        public ServiceAttribute()
        {
        }

        public ServiceAttribute(Type interfaceType)
        {
            if (!interfaceType.IsInterface)
            {
                throw new ArgumentException(nameof(interfaceType));
            }
            this.InterfaceType = interfaceType;
        }
    }
}