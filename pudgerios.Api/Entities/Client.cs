using System;
using System.ComponentModel.DataAnnotations;

namespace Pudgerios.Api.Entities
{
		public class Client
		{
				public Guid Id {get; set;}
				[Required]
				public string FirstName {get; set;}
				[Required]
				public string SecondName {get; set;}
				public string? MiddleName {get; set;}
				[Required]
				public string Email {get; set;}
				[Required]
				public string Phone {get; set;}
		}
}
