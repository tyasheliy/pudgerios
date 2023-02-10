using Pudgerios.Api.Data;
using Pudgerios.Api.Entities;
using Pudgerios.Api.Interfaces;

namespace Pudgerios.Api.Services
{
		public class UserService : IUserService
		{
				private DataContext _db;

				public UserService(DataContext db) => _db = db;

				public async Task DeleteUser(Guid id)
				{
						var user = await _db.Users.FindAsync(id);
						if (user == null) throw new NullReferenceException();
						_db.Users.Remove(user);
						await _db.SaveChangesAsync();
				}

				public async Task<bool> AuthUser(string login, string password)
				{
						throw new NotImplementedException();
				}

				public async Task<bool> RegisterUser(string login, string password, string role)
				{
						throw new NotImplementedException();
				}

				public async Task<User> GetUser(Guid id)
				{
						throw new NotImplementedException();
				}

				public async Task<Guid> GetUserId(string login)
				{
						throw new NotImplementedException();
				}

				public async Task ChangeUser(User user)
				{
						throw new NotImplementedException();
				}

				public void Dispose()
				{
						GC.ReRegisterForFinalize(this);
				}
		}
}
