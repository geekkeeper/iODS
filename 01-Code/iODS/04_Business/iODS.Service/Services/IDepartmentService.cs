using System.Collections.Generic;
using System.Threading.Tasks;
using iODS.Service.ViewModel;

namespace iODS.Service
{
    public interface IDepartmentService
    {
        /// <summary>
        /// 单个添加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<bool> Add(DepartmentViewModel model);

//        /// <summary>
//        /// 批量添加
//        /// </summary>
//        /// <param name="models"></param>
//        /// <returns></returns>
//        Task<bool> BatchAdd(IEnumerable<T> models);

        /// <summary>
        /// 删除单个
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> Delete(int id);

        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        Task<bool> BatchDelete(IEnumerable<int> ids);

        /// <summary>
        /// 单个更新
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<bool> Update(DepartmentViewModel model);

//        /// <summary>
//        /// 单个更新
//        /// </summary>
//        /// <param name="model"></param>
//        /// <returns></returns>
//        Task<bool> BatchUpdate(IEnumerable<T> model);

        /// <summary>
        /// 查询单个
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<DepartmentViewModel> GetById(int id);

        /// <summary>
        /// 查询所有
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<DepartmentViewModel>> GetAll();
    }
}