using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TestASPApp.ModelsDTO
{
	public class UserDTO
	{
		public int Id { get; set; }

		[Required]
		[DisplayName("First name")]
		public string FirstName { get; set; }

		[Required]
		[DisplayName("Last name")]
		public string LastName { get; set; }

		[DataType(DataType.PhoneNumber, ErrorMessage = "Not a valid Phone number")]
		[RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
		[DisplayName("Phone number")]
		public string PhoneNumber { get; set; }


		[DataType(DataType.EmailAddress, ErrorMessage = "Not a valid Email address")]
		[DisplayName("Email")]
		public string Email { get; set; }
	}
}