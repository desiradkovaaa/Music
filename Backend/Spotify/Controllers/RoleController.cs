using Microsoft.AspNetCore.Mvc;
using Spotify.Data.Models;
using Spotify.Persistence.Services;

namespace Spotify.Controllers
{
    public class RoleController: GenericController<Role>
    {
        public RoleController(GenericService<Role> service): base(service)
        {

        }
    }
}
