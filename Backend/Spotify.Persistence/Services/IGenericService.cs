using Spotify.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Spotify.Persistence.Services
{
    public interface IGenericService<T>
        where T : Generic
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task Post(T obj);
        Task Put(T obj);
        Task Delete(int id);

    }

}