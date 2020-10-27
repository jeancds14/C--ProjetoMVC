using ProjetoMVC.Context;
using ProjetoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMVC.Service
{
    public class MovieService
    {
        public void CreateMovie(Movie movie)
        {
            using (var db = new ApplicationContext())
            {
                db.Movies.Add(movie);
                db.SaveChanges();
            }
        }

        public Movie GetMovie(int id)
        {
            using (var db = new ApplicationContext())
            {
                var result = db.Movies.Where(x => x.Id == id).FirstOrDefault();
                return result;
            }
        }

        public List<Movie> GetAllMovie()
        {
            using (var db = new ApplicationContext())
            {
                var result = db.Movies.ToList();
                return result;
            }
        }

        public void DeleteMovie(int id)
        {
            using (var db = new ApplicationContext())
            {
                var result = db.Movies.Find(id);
                db.Movies.Remove(result);
                db.SaveChanges();
            }
        }

        public Movie UpdateProduct(Movie movie)
        {
            using (var db = new ApplicationContext())
            {
                db.Movies.Update(movie);
                db.SaveChanges();
                return movie;
            }
        }
    }
}
