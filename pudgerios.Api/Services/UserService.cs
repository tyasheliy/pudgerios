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
						var user = await Task.FromResult(_db.Users.FirstOrDefault(x => x.Login == login & x.Password == password));
						if (user == null) return false;
						return true;
				}

				public async Task<bool> RegisterUser(string login, string password, string role)
				{
						var user = await Task.FromResult(_db.Users.FirstOrDefault(x => x.Login == login & x.Password == password));
						if (user != null) return false;
						var newuser = new User
						{
								Id = Guid.NewGuid(),
								Login = login,
								Password = password,
								Role = role
						};
						_db.Users.Add(newuser);
						await _db.SaveChangesAsync();
						return true;
				}

				public async Task<User> GetUser(Guid id)
				{
						var user = await _db.Users.FindAsync(id);
						if (user == null) throw new NullReferenceException();
						return user;
				}

				public async Task<Guid> GetUserId(string login)
				{
						var user = await Task.FromResult(_db.Users.FirstOrDefault(x => x.Login == login));
						if (user == null) return Guid.Empty;
						return user.Id;
				}

				public async Task ChangeUser(User user)
				{
						var u = await _db.Users.FindAsync(user.Id);
						if (u == null) throw new NullReferenceException();
						u.Password = user.Password;
						u.Role = user.Role;
						await _db.SaveChangesAsync();
				}

				public void Dispose()
				{
						GC.ReRegisterForFinalize(this);
				}
		}
}
