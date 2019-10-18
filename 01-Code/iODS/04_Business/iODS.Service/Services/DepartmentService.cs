using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Hollysys.Common.Attribute;
using iODS.Domain;
using iODS.Model;
using iODS.Service.ViewModel;

namespace iODS.Service
{
    [Service]
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _repository;
        private readonly IMapper               _mapper;

        public DepartmentService(IDepartmentRepository repository, IMapper mapper)
        {
            this._repository = repository;
            this._mapper     = mapper;
        }

        public async Task<bool> Add(DepartmentViewModel model)
        {
            var entity     = this._mapper.Map<Department>(model);
            return  await this._repository.Add(entity);
        }

        public async Task<bool> Delete(int id)
        {
            return await this._repository.Delete(id);
        }

        public async Task<bool> BatchDelete(IEnumerable<int> ids)
        {
            return await this._repository.Delete(ids);
        }

        public async Task<bool> Update(DepartmentViewModel model)
        {
            return await this._repository.Update(this._mapper.Map<Department>(model));
        }

        public async Task<DepartmentViewModel> GetById(int id)
        {
            return this._mapper.Map<DepartmentViewModel>(await this._repository.Query(id));
        }

        public async Task<IEnumerable<DepartmentViewModel>> GetAll()
        {
            return this._mapper.Map<IEnumerable<DepartmentViewModel>>(await this._repository.Query());
        }

        private void ReleaseUnmanagedResources()
        {
            // TODO release unmanaged resources here
        }

        public void Dispose()
        {
            this.ReleaseUnmanagedResources();
            GC.SuppressFinalize(this);
        }

        ~DepartmentService()
        {
            this.ReleaseUnmanagedResources();
        }
    }
}