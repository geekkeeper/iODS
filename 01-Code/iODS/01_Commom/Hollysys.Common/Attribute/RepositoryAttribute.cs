using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Hollysys.Common.Attribute
{
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class)]
    public class RepositoryAttribute:System.Attribute,IFilterMetadata
    {
        
    }
}