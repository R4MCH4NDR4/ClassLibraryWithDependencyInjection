using System;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.infrastructure
{
	public class MovieRentalDbContext : DbContext, IMovieRentalDbContext
    {
		public MovieRentalDbContext(DbContextOptions<MovieRentalDbContext> options) : base(options)
		{

		}
        public DbSet<Movie> Movies { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

