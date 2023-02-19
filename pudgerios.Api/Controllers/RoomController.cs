using Pudgerios.Api.Entities;
using Pudgerios.Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Pudgerios.Api.Controllers
{
		[ApiController]
		[Route("api/rooms")]
		public class RoomController : ControllerBase
		{
				private IRoomService _rooms;

				public RoomController(IRoomService rooms) => _rooms = rooms;

				[HttpGet("{id}")]
				public async Task<IActionResult> GetRoom(string id)				
				{
					if (int.TryParse(id, out var intid))
					{
						try
						{
							await _rooms.GetRoom(intid);
						}
						catch
						{
							return BadRequest();
						}
						return Ok(await _rooms.GetRoom(intid));
					}
					return BadRequest();
				}

				[HttpPost("create")]
				public async Task<IActionResult> CreateRoom([FromBody] Room room)
				{
					try
					{
						await _rooms.CreateRoom(room);
					}
					catch
					{
						return BadRequest();
					}
					return Ok();
				}

				[HttpPost("clients/add/{id}")]
				public async Task<IActionResult> AddClient(string id, [FromBody] Client client)
				{
					if (int.TryParse(id, out var intid))
					{
						try
						{
							await _rooms.AddClient(intid, client);
						}
						catch
						{
							return BadRequest();
						}
						return Ok();
					}
					return BadRequest();
				}

				[HttpPost("clients/clear/{id}")]
				public async Task<IActionResult> ClearClient(string id)
				{
					if (int.TryParse(id, out var intid))
					{
						try
						{
							await _rooms.ClearClient(intid);
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
