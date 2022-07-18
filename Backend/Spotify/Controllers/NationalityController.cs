using Microsoft.AspNetCore.Mvc;
using Spotify.Application.Services;
using Spotify.Data.Models;

namespace Spotify.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NationalityController: GenericController<Nationality>
    {
        public NationalityController(GenericService<Nationality> service) : base(service)
        {
        }
    }
}
