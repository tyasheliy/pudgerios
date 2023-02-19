using Pudgerios.Api.Entities;
using Pudgerios.Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Pudgerios.Api.Controllers
{
		[ApiController]
		[Route("api/clients")]
		public class ClientController : ControllerBase
		{
				private IClientService _clients;

				public ClientController(IClientService clients) => _clients = clients;

				[HttpGet("get/client/{id}")]
				public async Task<IActionResult> GetClient(string id)
				{
					if (Guid.TryParse(id, out var guid))
					{
						try
						{
							await _clients.GetClient(guid);
						}
						catch
						{
							return BadRequest();
						}
						return Ok(await _clients.GetClient(guid));
					}
					return BadRequest();
				}

				[HttpGet("get/fullname/{id}")]
				public async Task<IActionResult> GetFullName(string id)
				{
					if (Guid.TryParse(id, out var guid))
					{
						try
						{
							await _clients.GetFullName(guid);
						}
						catch
						{
							return BadRequest();
						}
						return Ok(await _clients.GetFullName(guid));
					}
					return BadRequest();
				}

				[HttpPost]
				public async Task<IActionResult> CreateClient([FromBody] Client client)
				{
					try
					{
						await _clients.CreateClient(client);
					}
					catch
					{
						return BadRequest();
					}
					return Ok();
				}

				[HttpDelete("{id}")]
				public async Task<IActionResult> DeleteClient(string id)
				{
					if (Guid.TryParse(id, out var guid))
					{
						try
						{
							await _clients.DeleteClient(guid);
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
