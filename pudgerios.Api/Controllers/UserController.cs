using Pudgerios.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Pudgerios.Api.Controllers
{
		[ApiController]
		[Route("api/users")]
		public class UserController : ControllerBase
		{
			private IUserService _users;

			public UserController(IUserService users) => _users = users;

			[HttpGet("/get/user/{id}")]
			public async Task<IActionResult> GetUser(string id)
			{
				if (Guid.TryParse(id, out var guid))
				{
					var user = await _users.GetUser(guid);
					if (user == null) return NotFound();
					return Ok(user);
				}
				return NotFound();
			}

			[HttpGet("/get/id/{login}")]
			public async Task<IActionResult> GetUserId(string login)
			{
				var guid = await _users.GetUserId(login);
				if (guid == null) return NotFound();
				return Ok(guid);
			}

			[HttpPost("/register/{login}/{password}/{role}")]
			public async Task<IActionResult> RegisterUser(string login, string password, string role)
			{
				if (await _users.RegisterUser(login, password, role))
				{
					return Ok();
				}
				return BadRequest();
			}

			[HttpPost("/auth/{login}/{password}")]
			public async Task<IActionResult> AuthUser(string login, string password)
			{
				if (await _users.AuthUser(login, password))
				{
					return Ok();			
				}
				return BadRequest();
			}

			[HttpPost("/delete/{id}")]
			public async Task<IActionResult> DeleteUser(string id)
			{
				if (Guid.TryParse(id, out var guid))
				{
					try
					{
						await _users.DeleteUser(guid);
					}
					catch
					{
						return NotFound();
					}
					return Ok();
				}
				return NotFound();
			}

			[HttpPut("change")]
			public async Task<IActionResult> ChangeUser([FromBody] User user)
			{
				try
				{
					await ChangeUser(user);
				}
				catch
				{
					return BadRequest();
				}
				return Ok();
			}
		}
}
