using Pudgerios.Api.Entities;

namespace Pudgerios.Api.Interfaces
{
		public interface IRequestService : IDisposable
		{
				Task CreateRequest(Request request);

				Task AcceptRequest(Request request);

				Task DeclineRequest(Request request);

				Task<Request> GetRequest(Guid id);
		}
}
