using Spotify.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Data.Models
{
    public class SingerSong
    {
        public int SingerId { get; set; }
        public int SongId { get; set; }
        public Song Song { get; set; }
        public Singer Singer { get; set; }
    }
}
