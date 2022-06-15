using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Data.Models
{
    public class Generic
    {
        public int Id { get; set; }
        public string Alias { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int? ViewOrder { get; set; }
    }
}
