using ICT_profile.Data;

namespace ICT_profile.Repos;

public interface IContactRepo
{
    Contact? GetContact(Guid id);
}
