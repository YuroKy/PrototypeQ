using Microsoft.Extensions.DependencyInjection;
using PrototypeQ.Services.Abstractions.Managers;
using PrototypeQ.Services.Abstractions.Services;
using PrototypeQ.Services.Abstractions.Strategies;
using PrototypeQ.Services.Implementations.Managers;
using PrototypeQ.Services.Implementations.Services;
using PrototypeQ.Services.Implementations.Strategies;

namespace PrototypeQ.Services.Implementations.Extensions
{
	public static class DependencyInjectionExtension
	{
		public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
		{
			services.AddScoped<IFileImportManager, CsvImportManager>();
			services.AddScoped<IPersonService, PersonService>();
			services.AddScoped<ICsvReadingStrategy, LinearCsvReadingStrategy>();
			services.AddScoped<IFilterService, FilterService>();

			return services;
		}
	}
}
