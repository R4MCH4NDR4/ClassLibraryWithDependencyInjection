using System;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.infrastructure
{
	public interface IMovieRentalDbContext
	{
		 DbSet<Movie> Movies { set; get; }
	}
}

