using Pudgerios.Api.Interfaces;
using Pudgerios.Api.Entities;
using Pudgerios.Api.Data;

namespace Pudgerios.Api.Services
{
		public class ClientService : IClientService
		{
				private DataContext _db;

				public ClientService(DataContext db)
				{
					_db = db;
				}
					
				public async Task CreateClient(Client client)
				{
					if (client == null) throw new NullReferenceException();

					_db.Clients.Add(client);

					await _db.SaveChangesAsync();
				}

				public async Task<Client> GetClient(Guid id)
				{
						var client = await _db.Clients.FindAsync(id);

						if (client == null) throw new NullReferenceException();

						return client;
				}

				public async Task<string> GetFullName(Guid id)
				{
						var client = await _db.Clients.FindAsync(id);
						if (client == null) throw new NullReferenceException();
						return $"{client.SecondName} {client.FirstName}";
				}

				public void Dispose()
				{
						GC.ReRegisterForFinalize(this);
				}
		}
}
