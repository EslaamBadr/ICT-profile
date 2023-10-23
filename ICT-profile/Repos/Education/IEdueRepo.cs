using ICT_profile.Data;

namespace ICT_profile.Repos;

public interface IEdueRepo
{
    IEnumerable<Education> GetEdues(Guid id);
}
