using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieApi.Entities;
namespace MovieApi.Database
{
    public class MovieDBContext : DbContext
    {
        //Entity set
        public DbSet<Movie> Movies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //define connection string.
            optionsBuilder.UseSqlServer(@"Server=DEX;Database=Movie;Trusted_Connection=True;");
        }
    }
}