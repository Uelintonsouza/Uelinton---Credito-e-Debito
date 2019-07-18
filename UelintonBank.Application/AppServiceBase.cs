using System;
using System.Collections.Generic;
using System.Text;
using UelintonBank.Domain.Interfaces.Services;

namespace UelintonBank.Application
{
    public class AppServiceBase<TEntity> : IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {

            _serviceBase = serviceBase;
        }

        public void Add(TEntity obj)
        {
            _serviceBase.Add(obj);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _serviceBase.GetAll();

        }

        public TEntity GetById(int id)
        {
            return _serviceBase.GetById(id);
        }


        public void Remove(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity obj)
        {
            _serviceBase.Update(obj);
        }
    }
}
