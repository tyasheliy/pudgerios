using Pudgerios.Api.Entities;
using Pudgerios.Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Pudgerios.Api.Controllers
{
		[ApiController]
		[Route("api/requests")]
		public class RequestController : ControllerBase
		{
				private IRequestService _requests;

				public RequestController(IRequestService request) => _requests = request;

				[HttpGet("get/request/{id}")]
				public async Task<IActionResult> GetRequest(string id)
				{
					if (Guid.TryParse(id, out var guid))
					{
						try
						{
							await _requests.GetRequest(guid);
						}
						catch
						{
							return BadRequest();
						}
						return Ok(await _requests.GetRequest(guid));
					}
					return BadRequest();
				}

				[HttpPost("create")]
				public async Task<IActionResult> CreateRequest([FromBody] Request request)
				{
					try
					{
						await _requests.CreateRequest(request);
					}
					catch
					{
						return BadRequest();
					}
					return Ok();
				}

				[HttpPost("accept/{id}")]
				public async Task<IActionResult> AcceptRequest(string id)
				{
					if (Guid.TryParse(id, out var guid))
					{
						try
						{
							await _requests.AcceptRequest(guid);
						}
						catch
						{
							return BadRequest();
						}
						return Ok();
					}
					return BadRequest();
				}
		}
}
