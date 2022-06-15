using Spotify.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Data.Models
{
    public class Singer
    {
        public Nationality Nationality { get; set; }
        public int Id { get; set; }
        public string  FirstName { get; set;  }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set;  }
        public int CountOfAlbums { get; set; }
        public List<Song> Songs{ get; set; }
        public List<SingerSong> SingerSongs { get; set; }
    }
}
