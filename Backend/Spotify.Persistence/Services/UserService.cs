using Microsoft.EntityFrameworkCore;
using Spotify.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Persistence.Services
{
    public class UserService
    {
        private readonly AppDbContext db;
        public UserService()
        {

        }
            public UserService(AppDbContext db)
        {
            this.db = db;
        }
        public async Task<IEnumerable<User>> GetAll()
            {
            return await db.Users.ToListAsync();
            }
        public async Task<User> GetById(int id)
        {
            return await db.Users.FirstAsync(s=> s.Id==id);
        }
       public async Task Post(User obj)
        {
            if(obj==null)
            {
                throw new Exception("object is null");
            }
            db.Users.Add(obj);
            await db.SaveChangesAsync();
        }
        public async Task<User> Put(User obj)
        {
            if(obj==null)
            {
                throw new Exception("Obejct is null");
            }
            var existingUser = await db.Users.FirstOrDefaultAsync(x => x.Id == obj.Id);
            if (existingUser != null)
            {
                existingUser.UserName = obj.UserName;
                existingUser.Email = obj.Email;
                existingUser.Password = obj.Password;
                existingUser.Role = obj.Role;
                existingUser.Playlists = obj.Playlists;
                existingUser.UserPlaylists = obj.UserPlaylists;
                await db.SaveChangesAsync();
            }

            return existingUser;
        }
        public async Task Delete(int id)
        {
            var model = await db.Users.FirstOrDefaultAsync(x => x.Id == id);
            if (model == null)
            {
                throw new Exception("Invalid Data");
            }
            db.Users.Remove(model);
            await db.SaveChangesAsync();

        }
    }

    }
