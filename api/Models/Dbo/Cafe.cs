using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CafeApi.Models.Dbo
{
	[Table("cafe")]
	public class Cafe
	{
		[Key, Column("id")]
		public Guid Id { get; set; }

		[Column("name")]
		public required string Name { get; set; }

		[Column("description")]
		public required string Description { get; set; }

		[Column("logo")]
		public string? Logo { get; set; }

		[Column("location")]
		public required string Location { get; set; }
	}
}
