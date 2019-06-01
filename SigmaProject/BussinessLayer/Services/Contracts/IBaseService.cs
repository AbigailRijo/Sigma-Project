using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Services.Contracts
{
    public interface IBaseService<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<bool> Create(T EntityToCreate);
        Task<bool> Delete(T EntityToDelete);
        Task<bool> SoftDelete(int id);
        Task <T> Edit(T EntityToEdit);
        Task<T> GetById(int id);
    }
}
