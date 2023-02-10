using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pudgerios.Api.Entities
{
		public class Room
		{
			public int Id {get; set;}
			[Required]
			public string Type {get; set;}
			[Required]
			public int Seats {get; set;}
			public List<Client>? Clients {get; set;}
		}
}
