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

    public ContactUpdateVM? GetContactToUpdate(Guid id)
    {
        Contact? contact = _contactRepo.GetContact(id);
        if (contact is null)
        {
            return null;
        }

        return new ContactUpdateVM
        {
            UserId = (Guid)contact.UserId,
            Email = contact.Email,
            PhoneNumber = contact.PhoneNumber,
            Address = contact.Address
        };
    }

    public void UpdateUserContact(ContactUpdateVM contactUpdateVM)
    {
        Contact? contact = _contactRepo.GetContact(contactUpdateVM.UserId);
        if (contact == null)
        {
            return;
        }
        contact.PhoneNumber = contactUpdateVM.PhoneNumber;
        contact.Address = contactUpdateVM.Address;
        _contactRepo.UpdateUserContact(contact);
        _contactRepo.SaveChanges();
    }
}
