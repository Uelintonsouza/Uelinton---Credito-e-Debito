using System;
using System.Collections.Generic;
using UelintonBank.Domain.Interfaces;
using UelintonBank.Domain.Interfaces.Services;

namespace UelintonBank.Domain
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;



        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;

        }
        public void Add(TEntity obj)
        {
            _repository.Add(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }


        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<TEntity> GetAll()
        {
          return  _repository.GetAll();
        }

        public void Update(TEntity obj)
        {
            _repository.Update(obj);
        }
    }
}
