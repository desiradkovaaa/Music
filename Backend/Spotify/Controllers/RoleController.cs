using Spotify.Application.Services;
using Spotify.Data.Models;

namespace Spotify.Controllers
{
    public class RoleController: GenericController<Role>
    {
        public RoleController(GenericService<Role> service): base(service)
        {

        }
    }
}
