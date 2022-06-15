using Spotify.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Data.Models
{
    public class UserPlaylist
    {
        public int UserId {get; set; }
        public int PlaylistId { get; set;}
        public Playlist Playlist { get; set;}
        public User User { get; set;}
       


    }
}
