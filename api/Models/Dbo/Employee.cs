using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CafeApi.Models.Dbo
{
	[Table("employee")]
	public class Employee
	{
		[Key, Column("id")]
		public required string Id { get; set; }

		[Column("name")]
		public required string Name { get; set; }

		[Column("email_address")]
		public required string EailAddress { get; set; }

		[Column("phone_number")]
		public required string PhoneNumber { get; set; }

		[Column("gender")]
		public required string Gender { get; set; }
	}
}
