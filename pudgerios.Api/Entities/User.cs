using System;
using System.ComponentModel.DataAnnotations;

namespace Pudgerios.Api.Entities
{
		public class User
		{
				public Guid Id {get; set;}
				[Required]
				public string Login {get; set;}
				[Required]
				public string Password {get; set;}
				[Required]
				public string Role {get; set;}
		}
}
