using Pudgerios.Api.Entities;

namespace Pudgerios.Api.Interfaces
{
		public interface IClientService : IDisposable
		{
			Task CreateClient(Client client);

			Task<Client> GetClient(Guid id);

			Task<string> GetFullName(Guid id);
		}
}
