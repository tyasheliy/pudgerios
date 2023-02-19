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
			public Client? Client {get; set;}
		}
}
