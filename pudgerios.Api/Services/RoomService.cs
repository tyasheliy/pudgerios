using Pudgerios.Api.Entities;
using Pudgerios.Api.Data;
using Pudgerios.Api.Interfaces;

namespace Pudgerios.Api.Services
{
	public class RoomService : IRoomService
	{
		private DataContext _db;

		public RoomService(DataContext db) => _db = db;

		public async Task CreateRoom(Room room)
		{
			_db.Rooms.Add(room);
			await _db.SaveChangesAsync();
		}

		public async Task<Room> GetRoom(int id)
		{
			var room = await _db.Rooms.FindAsync(id);
			if (room == null) throw new NullReferenceException();
			return room;
		}

		public async Task AddClient(int id, Client client)
		{
			var room = await _db.Rooms.FindAsync(id);
			if (room == null) throw new NullReferenceException();
			room.Clients.Add(client);
			await _db.SaveChangesAsync();
		}

		public async Task ClearClients(int id)
		{
			var room = await _db.Rooms.FindAsync(id);
			if (room == null) throw new NullReferenceException();
			room.Clients.Clear();
			await _db.SaveChangesAsync();
		}

		public void Dispose()
		{
				GC.ReRegisterForFinalize(this);
		}
	}
}
