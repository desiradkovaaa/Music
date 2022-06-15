using Microsoft.EntityFrameworkCore;
using Spotify.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Persistence.Services
{
    public class PlaylistService
    {
        private readonly AppDbContext db;
        public PlaylistService()
        {

        }
        public PlaylistService(AppDbContext db)
        {
            this.db = db;
        }
        public async Task<IEnumerable<Playlist>> GetAll()
        {
            return await db.Playlists.ToListAsync();
        }
        public async Task<Playlist> GetById(int id)
        {
            return await db.Playlists.SingleOrDefaultAsync(s=>s.Id==id);
        }
        public async Task Post(Playlist obj)
        {
            if(obj==null)
            {
                throw new Exception("obj is null");
            }
            db.Playlists.Add(obj);
            await db.SaveChangesAsync();
        }
        public async Task<Playlist> Put(Playlist obj)
        {
            if (obj == null)
            {
                throw new Exception("Invalid data");
            }
            var existingPlaylist = await db.Playlists.FirstOrDefaultAsync(x => x.Id == obj.Id);
            if (existingPlaylist != null)
            {
                existingPlaylist.Name = obj.Name;
                existingPlaylist.Songs = obj.Songs;
                existingPlaylist.UserPlaylists = obj.UserPlaylists;
                await db.SaveChangesAsync();
            }

            return existingPlaylist;
        }
        public async Task Delete(int id)
        {
            var model = await db.Playlists.FirstOrDefaultAsync(x => x.Id == id);
            if (model == null)
            {
                throw new Exception("Invalid Data");
            }
            db.Playlists.Remove(model);
            await db.SaveChangesAsync();
        }


    }
    }

