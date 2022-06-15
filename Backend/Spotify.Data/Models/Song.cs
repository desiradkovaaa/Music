using Spotify.Data.Models;
using System.Collections.Generic;

namespace Spotify.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Album { get; set; }
        public Genre Genre { get; set; }
        public Singer Singer { get; set; }
        public int Duration { get; set; }
        public int Year { get; set;  }
        public List<SingerSong> SingerSongs { get; set; }


    }
}
