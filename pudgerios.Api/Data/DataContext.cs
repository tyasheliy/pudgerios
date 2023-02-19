using Microsoft.EntityFrameworkCore;
using Pudgerios.Api.Entities;

namespace Pudgerios.Api.Data
{
		public class DataContext : DbContext
		{
				public DataContext(DbContextOptions<DataContext> options) : base(options)
				{

				}

				public DbSet<Client> Clients {get; set;}

				public DbSet<Request> Requests {get; set;}

				public DbSet<Room> Rooms {get; set;}

				public DbSet<User> Users {get; set;}
		}
}
