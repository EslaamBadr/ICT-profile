using ICT_profile.Data;

namespace ICT_profile.Manegers;

public interface IContactManeger
{
    ContactReadVM GetContact(Guid id);
    ContactUpdateVM? GetContactToUpdate(Guid id);
    void UpdateUserContact(ContactUpdateVM contactUpdateVM);
}
