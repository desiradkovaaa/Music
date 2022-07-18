using Microsoft.AspNetCore.Mvc;
using Spotify.Application.Services;
using Spotify.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Spotify.Controllers
{
    [ApiController]
    [Route("[Controller]")]

    public class SingerController
    {
        private SingerService service;
        public SingerController(SingerService service)
        {
            this.service = service;
        }
        public SingerService Service { get; }
        [HttpGet]
        public async Task<IEnumerable<Singer>> GetAll()
        {
            return await service.GetAll();
        }
        [HttpGet("{id}")]
        public async Task<Singer> GetById(int id)
        {
            return await service.GetById(id);
        }
        [HttpPost]
        public async Task Post([FromBody]Singer obj)
        {
           await service.Post(obj);
        }
        [HttpPut]
        public async Task<Singer> Put(Singer obj)
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
