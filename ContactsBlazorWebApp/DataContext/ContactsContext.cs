using ContactsBlazorWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactsBlazorWebApp.DataContext
{
    public class ContactsContext : DbContext
    {
        public ContactsContext(DbContextOptions<ContactsContext> options) : base(options)
        {
        }
        public DbSet<ContactDetail> ContactDetails { get; set; }
    }
}
