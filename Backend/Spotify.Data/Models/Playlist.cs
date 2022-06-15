using Spotify.Data.Models;
using Spotify.Models;
using System.Collections.Generic;

namespace Spotify.Data.Models
{
    public class Playlist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Song> Songs { get; set; }
        public List<UserPlaylist> UserPlaylists{ get; set; }
    }
}
