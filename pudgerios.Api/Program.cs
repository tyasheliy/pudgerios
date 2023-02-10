using Pudgerios.Api.Data;
using Pudgerios.Api.Interfaces;
using Pudgerios.Api.Services;
using Microsoft.EntityFrameworkCore;

namespace Pudgerios.Api
{
		public static class Program
		{
				public static int Main(string[] args)
				{
					var builder = WebApplication.CreateBuilder(args);
					var services = builder.Services;
					
					services.AddControllers();

					services.AddDbContext<DataContext>(o => o.UseSqlite("Filename=pudgerios.db"));

					services.AddScoped<IClientService>(s => new ClientService(s.GetRequiredService<DataContext>()));
					services.AddScoped<IUserService>(s => new UserService(s.GetRequiredService<DataContext>()));
					services.AddScoped<IRequestService>(s => new RequestService(s.GetRequiredService<DataContext>()));
					services.AddScoped<IRoomService>(s => new RoomService(s.GetRequiredService<DataContext>()));

					var app = builder.Build();
					
					app.UseRouting();
					app.UseEndpoints(e => e.MapControllers());

					app.Run();

					return 0;
				}
		}
}

