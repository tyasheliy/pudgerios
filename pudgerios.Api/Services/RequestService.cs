using Pudgerios.Api.Entities;
using Pudgerios.Api.Interfaces;
using Pudgerios.Api.Data;

namespace Pudgerios.Api.Services
{
		public class RequestService : IRequestService
		{
				private DataContext _db;

				public RequestService(DataContext db) => _db = db;

				public async Task CreateRequest(Request request)
				{
					_db.Requests.Add(request);
					await _db.SaveChangesAsync();
				}

				public async Task AcceptRequest(Request request)
				{
					throw new NotImplementedException();
				}

				public async Task DeclineRequest(Request request)
				{
						throw new NotImplementedException();
				}

				public async Task<Request> GetRequest(Guid id)
				{
						var request = await _db.Requests.FindAsync(id);
						if (request == null) throw new NullReferenceException();
						return request;
				}

				public void Dispose()
				{
						GC.ReRegisterForFinalize(this);
				}
		}
}
