using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieApi.Entities;
namespace MovieApi.Interfaces
{
    public interface MovieInterface
    {
        List<Movie> GetAll();
        Movie GetById(int id);
        Movie GetByActor(string actor);
        Movie GetByLanguage(string language);
        Movie GetByDirector(string director);
        void Add(Movie Movie);
        void Delete(int id);
        void Edit(Movie Movie);
    }
}