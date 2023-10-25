using ICT_profile.Data;

namespace ICT_profile.Repos;

public class ContactRepo : IContactRepo
{
    private readonly ICTcontext _context;
    public ContactRepo(ICTcontext context)
    {
        _context = context;
    }

    public Contact? GetContact(Guid id)
    {
        return _context.Users.Where(a => a.Id == id).Select(a => a.Contact).FirstOrDefault();
        //return _context.Contacts.Where(p=>p.UserId == id).FirstOrDefault();
    }

    public void UpdateUserContact(Contact contact)
    {
        _context.Contacts.Update(contact);
    }

    public int SaveChanges()
    {
        return _context.SaveChanges();
    }
}
