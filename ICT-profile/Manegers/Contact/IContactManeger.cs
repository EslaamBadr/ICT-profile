using ICT_profile.Data;

namespace ICT_profile.Manegers;

public interface IContactManeger
{
    ContactReadVM GetContact(Guid id);
}
