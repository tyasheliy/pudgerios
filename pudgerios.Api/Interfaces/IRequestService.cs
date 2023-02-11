using Pudgerios.Api.Entities;

namespace Pudgerios.Api.Interfaces
{
		public interface IRequestService : IDisposable
		{
				Task CreateRequest(Request request);

				Task AcceptRequest(Guid id);

				Task DeclineRequest(Guid id);

				Task<Request> GetRequest(Guid id);
		}
}
