using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace PrototypeQ.Api
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddCors();
			services.AddMvc();
		}

		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			app.UseDefaultFiles();
			app.UseStaticFiles();
			app.UseCors(builder => builder
				.AllowAnyOrigin()
				.AllowAnyMethod()
				.AllowAnyHeader()
				.AllowCredentials());
			app.UseMvc();
		}
	}
}
