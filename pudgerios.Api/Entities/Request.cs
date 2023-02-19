using System.ComponentModel.DataAnnotations;

namespace Pudgerios.Api.Entities
{
		public class Request
		{
				public Guid Id {get; set;}
				[Required]
				public Client Client {get; set;}
				[Required]
				public int Suits {get; set;}
				[Required]
				public Room Room {get; set;}
				[Required]
				public DateTime PublishDate {get; set;}
				[Required]
				public DateTime BeginData {get; set;}
				[Required]
				public DateTime EndDate {get; set;}
				public string Status {get; set;}
		}
}
