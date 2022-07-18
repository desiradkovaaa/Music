
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Spotify.Data.Models;
using Spotify.Persistence;

namespace Spotify.Application.Services
{
    public class GenericService<T> : IGenericService<T>
        where T : Generic
    {
        private readonly AppDbContext db;
        public GenericService()
        {

        }
        public GenericService(AppDbContext db)
        {
            this.db = db;
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return await db.Set<T>().ToListAsync();
        }
        public async Task<T> GetById(int Id)
        {
            return await db.Set<T>().SingleOrDefaultAsync(s => s.Id == Id);
        }

        public async Task Post(T obj)
        {
            if (obj == null)
            {
                throw new Exception("obj is null");
            }

            db.Set<T>().Add(obj);

            await db.SaveChangesAsync();

        }
        public async Task<T> Put(T obj)
        {
            if (obj == null)
            {
                throw new Exception("Invalid data");
            }
            var item = await db.Set<T>().FirstOrDefaultAsync(x => x.Id == obj.Id);
            if (item != null)
            {
                item.Name = obj.Name;
                item.Alias = obj.Alias;
                item.IsActive = obj.IsActive;
                item.ViewOrder = obj.ViewOrder;
                await db.SaveChangesAsync();
            }

            return item;
        }

        public async Task Delete(int id)
        {

            var model = await db.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
            if (model == null)
            {
                throw new Exception("Invalid Data");
            }

            db.Set<T>().Remove(model);
            await db.SaveChangesAsync();
        }

        Task IGenericService<T>.Put(T obj)
        {
            throw new System.NotImplementedException();
        }
    }
}