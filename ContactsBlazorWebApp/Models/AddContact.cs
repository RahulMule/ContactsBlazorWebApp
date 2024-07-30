namespace ContactsBlazorWebApp.Models
{
	public class AddNewContact
	{
		public required string Name { get; set; }
		public string? Email { get; set; }
		public string? Phone { get; set; }
		public DateOnly DateOfBirth { get; set; }
	}
}
