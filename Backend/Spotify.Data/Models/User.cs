using Spotify.Models;
using System.Collections.Generic;

namespace Spotify.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set;  }
        public List<Playlist> Playlists { get; set; }
        public List<UserPlaylist> UserPlaylists { get; set; }
    }

}
