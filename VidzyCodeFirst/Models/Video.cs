using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.AccessControl;

namespace VidzyCodeFirst.Models
{
    public class Video
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Genre Genre { get; set; }
        public int GennreId { get; set; }
        public Classification Classification { get; set; }
        public ICollection<Tag> Tags { get; set; }
        
    }
}
