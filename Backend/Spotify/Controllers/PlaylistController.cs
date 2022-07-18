using Microsoft.AspNetCore.Mvc;
using Spotify.Application.Services;
using Spotify.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Spotify.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class PlaylistController
    {
        private PlaylistService service;
        public PlaylistController(PlaylistService service)
        {
            this.service = service;
        }
        public PlaylistService Service { get; }
        [HttpGet]
        public async Task<IEnumerable<Playlist>> GetAll()
        {
            return await service.GetAll();
        }
        [HttpDelete("{id}")]
        public async Task<Playlist> GetById(int id)
        {
            return await service.GetById(id);
        }
        [HttpPost]
        public async Task Post(Playlist obj)
        {
            await service.Post(obj);
        }
        [HttpPut]
        public async Task<Playlist> Put(Playlist obj)
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
    
