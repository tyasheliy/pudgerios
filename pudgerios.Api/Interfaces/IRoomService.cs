using Pudgerios.Api.Entities;

namespace Pudgerios.Api.Interfaces
{
		public interface IRoomService : IDisposable
		{
				Task CreateRoom(Room room);

				Task<Room> GetRoom(int id);

				Task AddClient(int id, Client client);

				Task ClearClients(int id);
		}
}
