using Microsoft.EntityFrameworkCore;
using Spotify.Data.Models;
using Spotify.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spotify.Persistence;

namespace Spotify.Application.Services
{
    public class SongService
    {
        private readonly AppDbContext db;
        public SongService()
        {

        }
        public SongService(AppDbContext db)
        {
            this.db = db;
        }
        public async Task<IEnumerable<Song>> GetAll()
        {
            return await db.Songs.ToListAsync();
        }
        public async Task <Song> GetById(int id)
        {
            return await db.Songs.SingleOrDefaultAsync(s=> s.Id==id);
        }
        public async Task Post(Song obj)
        {
            if(obj==null)
            {
                throw new Exception("Obj is null");
            }
            db.Songs.Add(obj);
            await db.SaveChangesAsync();

        }
        public async Task<Song>Put(Song obj)
        {
            if(obj==null)
            {
                throw new Exception("Obj is null");
            }
            var existingSong = await db.Songs.FirstOrDefaultAsync(x => x.Id == obj.Id);
            if (existingSong != null)
            {
                existingSong.Name = obj.Name;
                existingSong.Album = obj.Album;
                existingSong.Genre = obj.Genre;
                existingSong.Singer = obj.Singer;
                existingSong.Duration = obj.Duration;
                existingSong.Year = obj.Year;
                existingSong.SingerSongs = obj.SingerSongs;
                await db.SaveChangesAsync();
            }

            return existingSong;
        }
        public async Task Delete(int id)
        {
            var model = await db.Songs.FirstOrDefaultAsync(x => x.Id == id);
            if (model == null)
            {
                throw new Exception("Invalid Data");
            }
            db.Songs.Remove(model);
            await db.SaveChangesAsync();

        }
    }

   
}