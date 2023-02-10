using Pudgerios.Api.Entities;

namespace Pudgerios.Api.Interfaces
{
		public interface IUserService : IDisposable
		{
			Task DeleteUser(Guid id);

			Task<bool> AuthUser(string login, string password);

			Task<bool> RegisterUser(string login, string password, string role);

			Task<User> GetUser(Guid id);

			Task<Guid> GetUserId(string login);

			Task ChangeUser(User user);
		}
}
