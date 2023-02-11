using Pudgerios.Api.Interfaces;
using Pudgerios.Api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Pudgerios.Api.Controllers
{
		[ApiController]
		[Route("api/users")]
		public class UserController : ControllerBase
		{
			private IUserService _users;
			
			public UserController(IUserService users) => _users = users;
			
			[HttpGet("get/user/{id}")]
			public async Task<IActionResult> GetUser(string id)
			{
				if (Guid.TryParse(id, out var guid))
				{
					try
					{
						await _users.GetUser(guid);
					}
					catch
					{
						return BadRequest();
					}
					return Ok(await _users.GetUser(guid));
				}
				return BadRequest();
			}

			[HttpGet("get/id/{login}")]
			public async Task<IActionResult> GetUserId(string login)
			{
				try
				{
					await _users.GetUserId(login);
				}
				catch
				{
					return BadRequest();
				}
				return Ok(await _users.GetUserId(login));
			}

			[HttpPost("register/{login}/{password}/{role}")]
			public async Task<IActionResult> RegisterUser(string login, string password, string role)
			{
				if (await _users.RegisterUser(login, password, role))
				{
					return Ok();
				}
				return BadRequest();
			}

			[HttpPost("auth/{login}/{password}")]
			public async Task<IActionResult> AuthUser(string login, string password)
			{
				if (await _users.AuthUser(login, password))
				{
					return Ok();			
				}
				return BadRequest();
			}

			[HttpDelete("{id}")]
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
						return BadRequest();
					}
					return Ok();
				}
				return BadRequest();
			}

			[HttpPut]
			public async Task<IActionResult> ChangeUser([FromBody] User user)
			{
				try
				{
					await _users.ChangeUser(user);
				}
				catch
				{
					return BadRequest();
				}
				return Ok();
			}
		}
}
