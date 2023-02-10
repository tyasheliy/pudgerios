using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pudgerios.Api.Entities
{
		public class Request
		{
				public Guid Id {get; set;}
				[Required]
				public List<Client> Clients {get; set;}
				[Required]
				public Room Room {get; set;}
				[Required]
				public DateTime Date {get; set;}
				
				public bool Status {get; set;}
		}
}
