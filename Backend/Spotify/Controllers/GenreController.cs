using Microsoft.AspNetCore.Mvc;
using Spotify.Data.Models;
using Spotify.Persistence.Services;

namespace Spotify.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class GenreController: GenericController<Genre>

    {
        public GenreController (GenericService<Genre> service) : base(service)
        {
        }
    }
}
