using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using MovieRental.Dtos;
using MovieRental.Models;
using Vidly.Models;

namespace MovieRental.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpGet]
        public IEnumerable<MovieDto> Movies()
        {
            return _context.Movies.ToList().Select(Mapper.Map<Movie, MovieDto>);
        }

    }
}
