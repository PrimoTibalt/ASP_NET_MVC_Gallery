using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Gallery.Models;

namespace Gallery.DAL
{
    public class MyContext : DbContext
    {
        public MyContext() : base("Default Connection")
        {

        }

        public DbSet<Photo> Photoes { get; set; }
    }
}