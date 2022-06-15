using Microsoft.EntityFrameworkCore;
using Spotify.Data.Models;
using Spotify.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Spotify.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base()
        {
        }
        public AppDbContext(DbContextOptions<AppDbContext> options)
              : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<UserPlaylist> UserPlaylists { get; set; }

        internal Task<IEnumerable<Playlist>> ToListAsync()
        {
            throw new NotImplementedException();
        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Nationality> Nationalities { get; set;  }
        public DbSet<Role> Roles { get; set;  }
        public DbSet<Singer> Singers{ get; set;  }
        public DbSet<SingerSong> SingerSongs { get; set;  }
        const string connectionString = "Host = localhost; Port = 5432; UserId = postgres; Password = LondoNVS2023; Database = AppDbContext";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(connectionString);
            }

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

          /// modelBuilder.Entity<UserPlaylist>().HasKey(c => new { c.UserId, c.PlaylistId });
            modelBuilder.Entity<UserPlaylist>().HasOne(UsP => UsP.User).WithMany(u => u.UserPlaylists).HasForeignKey(u => u.UserId);
            modelBuilder.Entity<UserPlaylist>().HasOne(UsP => UsP.Playlist).WithMany(u => u.UserPlaylists).HasForeignKey(u => u.PlaylistId);
            modelBuilder.Entity<UserPlaylist>().HasKey(StC => new { StC.UserId, StC.PlaylistId });
            modelBuilder.Entity<SingerSong>().HasOne(Ss => Ss.Singer).WithMany(s => s.SingerSongs).HasForeignKey(s => s.SingerId);
            modelBuilder.Entity<SingerSong>().HasOne(Ss => Ss.Song).WithMany(s => s.SingerSongs).HasForeignKey(s => s.SongId);
            modelBuilder.Entity<SingerSong>().HasKey(St => new { St.SingerId, St.SongId });





        }



    }
  
}
