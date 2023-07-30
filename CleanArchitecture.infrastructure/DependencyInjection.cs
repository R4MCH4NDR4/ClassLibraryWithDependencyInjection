using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.infrastructure
{
	public static class DependencyInjection
	{
		 
		public	static IServiceCollection ImplementPersistance(this IServiceCollection serviceCollection, IConfiguration configuration)
		{
			serviceCollection.AddDbContext<MovieRentalDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
				b => b.MigrationsAssembly(typeof(MovieRentalDbContext).Assembly.FullName)), ServiceLifetime.Transient);

            _ = serviceCollection.AddScoped<IMovieRentalDbContext>(provider =>
            provider.GetService<MovieRentalDbContext>());

			return serviceCollection;
		}
	}
}
	
