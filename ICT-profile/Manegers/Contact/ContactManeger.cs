using ICT_profile.Data;
using ICT_profile.Repos;

namespace ICT_profile.Manegers;

public class ContactManeger : IContactManeger
{
    private readonly IContactRepo _contactRepo;
    public ContactManeger(IContactRepo contactRepo) 
        {
            _contactRepo = contactRepo; 
        }

    public ContactReadVM GetContact(Guid id)
    {
        Contact? contact = _contactRepo.GetContact(id);
        if (contact is null)
        {
            return null;
        }
        return new ContactReadVM
        {
            Email = contact.Email,
            PhoneNumber = contact.PhoneNumber,
            Address = contact.Address
        };
    }
}
