using FinalBL.İmplementations.Interfaces;
using FinalDAL.İnterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalBL.İmplementations.Services
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private readonly IRepository<T> _repository;

        public GenericService(IRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task AddAsync(T entity)
        {
            await _repository.AddAsync(entity);

        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAll();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _repository.GetById(id);
        }



        public async Task HardDeleteAsync(int id)
        {
            await _repository.HardDelete(id);
        }

        public async Task SoftDeleteAsync(int id)
        {
            await _repository.SoftDelete(id);
        }

        public async Task UpdateAsync(T entity)
        {
            await _repository.Update(entity);
        }


    }
}
