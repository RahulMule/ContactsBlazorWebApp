using ContactsBlazorWebApp.DataContext;
using ContactsBlazorWebApp.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ContactsBlazorWebApp.Services
{
    public class ContactsRepository 
    {
        private readonly ContactsContext _context;
        public ContactsRepository(ContactsContext context)
        {
            _context = context;
        }

		public async Task DeleteContact(ContactDetail contact)
		{
			var Contact = _context.ContactDetails.Find(contact.Id);
            if(Contact != null)
            {
                _context.ContactDetails.Remove(Contact);
                _context.SaveChanges();
            }
		}

		public List<ContactDetail> GetContactDetails()
        {
            return _context.ContactDetails.ToList();  
        }
        public async Task AddContact(AddNewContact contact)
        {
            ContactDetail con = new ContactDetail() { Name = contact.Name, Email = contact.Email, DateOfBirth = contact.DateOfBirth, Phone = contact.Phone };
            await _context.ContactDetails.AddAsync(con);
            _context.SaveChanges();
        }
		public ContactDetail GetContactDetailsbyID(int id)
		{
            return _context.ContactDetails.Find(id);
		}
		public void UpdateContactDetails(ContactDetail contact)
		{
			_context.ContactDetails.Update(contact);
            _context.SaveChanges(true);
		}

	}
}
