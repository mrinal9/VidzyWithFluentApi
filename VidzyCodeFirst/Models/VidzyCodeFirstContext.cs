﻿using System.Data.Entity;
using System.Security.AccessControl;
using VidzyCodeFirst.EntityConfigurations;

namespace VidzyCodeFirst.Models
{
    public class VidzyCodeFirstContext:DbContext
    {
       public DbSet<Video> Videos { get; set; }
       public DbSet<Genre> Genres { get; set; }
       public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new VideoConfiguration());
            modelBuilder.Configurations.Add(new GenreConfiguration());
        }
    }

    
}
