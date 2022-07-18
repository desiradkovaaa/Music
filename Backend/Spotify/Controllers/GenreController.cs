using Microsoft.AspNetCore.Mvc;
using Spotify.Application.Services;
using Spotify.Data.Models;

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
