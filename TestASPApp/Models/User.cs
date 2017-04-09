using System.ComponentModel.DataAnnotations;

namespace TestASPApp.Models
{
	public class User
	{
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public string SecondName { get; set; }

		[DataType(DataType.PhoneNumber, ErrorMessage = "Not a valid Phone number")]
		[RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
		public string PhoneNumber { get; set; }


		[DataType(DataType.EmailAddress, ErrorMessage = "Not a valid Email address")]
		public string Email { get; set; }
	}
}