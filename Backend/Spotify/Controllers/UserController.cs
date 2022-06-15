using Microsoft.AspNetCore.Mvc;
using Spotify.Data.Models;
using Spotify.Persistence.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Spotify.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UserController
    {
        private UserService service;
        
        public UserController(UserService service)
        {
            this.service = service;
        }
        public UserService Service { get; }
        [HttpGet]
        public async Task<IEnumerable<User>> GetAll()
        {
            return await service.GetAll();
        }
        [HttpGet("{id}")]
        public async Task<User> GetById(int id)
        {
            return await service.GetById(id);
        }
        [HttpPost]
        public async Task Post(User obj)
        {
            await service.Post(obj);
        }
        [HttpPut]
        public async Task<User> Put(User obj)
        {
            return await service.Put(obj);
;       }
        [HttpGet("{id}")]
        public async Task Delete(int id)
        {
             await service.Delete(id);
        }
    }
}
