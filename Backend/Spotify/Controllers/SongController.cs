using Microsoft.AspNetCore.Mvc;
using Spotify.Application.Services;
using Spotify.Data.Models;
using Spotify.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Spotify.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class SongController
    {
        private SongService service;
        SongController(SongService service)
        {
            this.service = service;
        }
        public SongService Service { get; }
        [HttpGet]
        public async Task<IEnumerable<Song>> GetAll()
        {
            return await service.GetAll();
        }
        [HttpGet("{id}")]
        public async Task<Song> GetById(int id)
        {
            return await service.GetById(id);
        }
        [HttpPost]
        public async Task Post([FromBody]Song obj)
        {
            await service.Post(obj);
        }
        [HttpPut]
        public async Task<Song> Put(Song obj)
        {
            return await service.Put(obj);
        }
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await service.Delete(id);
        }


    }
}
