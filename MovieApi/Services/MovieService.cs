using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieApi.Entities;
using MovieApi.Interfaces;
using MovieApi.Database;
namespace MovieApi.Services
{
    public class MovieService : MovieInterface
    {
        private readonly MovieDBContext context;
        public MovieService()
        {
            this.context = new MovieDBContext();
        }
        public void Add(Movie Movie)
        {
            context.Movies.Add(Movie);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Movie Movie = context.Movies.SingleOrDefault(i => i.MovieId == id);
            context.Movies.Remove(Movie);
            context.SaveChanges();
        }

        public void Edit(Movie Movie)
        {
            context.Movies.Update(Movie);
            context.SaveChanges();
        }

        public List<Movie> GetAll()
        {
            return context.Movies.ToList();
        }
        public Movie GetById(int id)
        {
            Movie Movie = context.Movies.SingleOrDefault(i => i.MovieId == id);
            return Movie;
        }

        public Movie GetByActor(string actor)
        {
            Movie Movie = context.Movies.SingleOrDefault(i => i.Actor==actor);
            return Movie;
        }

        public Movie GetByLanguage(string language)
        {
            Movie Movie = context.Movies.SingleOrDefault(i => i.Language==language);
            return Movie;
        }

        public Movie GetByDirector(string director)
        {
            Movie Movie = context.Movies.SingleOrDefault(i => i.Director==director);
            return Movie;
        }
    }
}