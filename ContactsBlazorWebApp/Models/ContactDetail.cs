namespace ContactsBlazorWebApp.Models
{
    public class ContactDetail
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public DateOnly DateOfBirth { get; set; }
    }
}
