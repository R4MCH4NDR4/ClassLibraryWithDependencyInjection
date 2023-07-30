using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.infrastructure;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanArchitecture.Services.Controllers
{
    
    public class HomeController : ControllerBase
    {
        private readonly IMovieRentalDbContext _movieRentalDbContext;
        public HomeController(IMovieRentalDbContext movieRentalDbContext)
        {
            _movieRentalDbContext = movieRentalDbContext;
        }

        [HttpGet]
        public IActionResult GetMovies()
        {
            return Ok(_movieRentalDbContext.Movies.GetAsyncEnumerator());
        }
        
    }
}

