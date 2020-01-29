using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Gallery.Models
{
    [Serializable]
    public class Photo
    {
        public Photo()
        {

        }

        private Photo(string name)
        {
            this.Name = name;
        }

        public Photo(string name, string path) : this(name)
        {
            this.Path = path;
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Path { get; set; }
    }
}