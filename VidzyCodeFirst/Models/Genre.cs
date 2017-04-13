using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace VidzyCodeFirst.Models
{
    public class Genre
    {
        public Genre()
        {
            Movies = new Collection<Video>();
        }
        public int Id { get; set; }
    
        public String Name { get; set; }

        public ICollection<Video> Movies { get; set; }

    }

}
