using System;
using System.Collections;
using System.Collections.Generic;

namespace VidzyCodeFirst.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Video> Videos { get; set; }
    }
}