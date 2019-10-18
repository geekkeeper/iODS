using System;
using iODS.Service.ViewModel;

namespace iODS.Service
{
    public interface IBaseService<T>:IDisposable where T : BaseViewModel, new()
    {
        
    }
}