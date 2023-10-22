using ICT_profile.Data;

namespace ICT_profile.Repos;

public interface IEdueRepo
{
    IEnumerable<Education> GetEdues();
    Education? GetEdue(int id);
}
