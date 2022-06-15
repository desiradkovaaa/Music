using Microsoft.AspNetCore.Mvc;
using Spotify.Data.Models;
using Spotify.Persistence.Services;

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
