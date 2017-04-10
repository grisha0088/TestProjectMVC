using System.ComponentModel.DataAnnotations;

namespace TestASPApp.Models
{
	public class User
	{
		public int Id { get; set; }

		[Required]
		public string FirstName { get; set; }

		[Required]
		public string LastName { get; set; }

		public string PhoneNumber { get; set; }

		public string Email { get; set; }
	}
}