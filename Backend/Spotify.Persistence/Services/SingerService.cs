using Microsoft.EntityFrameworkCore;
using Spotify.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Persistence.Services
{
    public class SingerService
    {
        private readonly AppDbContext db;
        public SingerService()
        {

        }
        public SingerService(AppDbContext db)
        {
            this.db = db;
        }
        public async Task<IEnumerable<Singer>> GetAll()
        {
            return await db.Singers.ToListAsync();
        }
        public async Task<Singer> GetById (int id)
        {
            return await db.Singers.SingleOrDefaultAsync(s => s.Id == id);
        }
        public async Task  Post(Singer obj)
        {
            if (obj==null)
            {
                throw new Exception("object is null");
            }
            db.Singers.Add(obj);
            await db.SaveChangesAsync();
        }
        public async Task<Singer> Put(Singer obj)
        {
            if (obj == null)
            {
                throw new Exception("Invalid data");
            }
            var existingSinger = await db.Singers.FirstOrDefaultAsync(x => x.Id == obj.Id);
            if (existingSinger != null)
            {
                existingSinger.FirstName = obj.FirstName;
                existingSinger.MiddleName = obj.MiddleName;
                existingSinger.LastName = obj.LastName;
                existingSinger.Age = obj.Age;
                existingSinger.CountOfAlbums = obj.CountOfAlbums;
                existingSinger.Songs = obj.Songs;
                existingSinger.SingerSongs = obj.SingerSongs;
                await db.SaveChangesAsync();
            }

            return existingSinger;
        }
        public async Task Delete(int id)
        {
            var model = await db.Singers.FirstOrDefaultAsync(x => x.Id == id);
            if(model==null)
            {
                throw new Exception("Invalid Data");
            }
            db.Singers.Remove(model);
            await db.SaveChangesAsync();

        }
    }
}
