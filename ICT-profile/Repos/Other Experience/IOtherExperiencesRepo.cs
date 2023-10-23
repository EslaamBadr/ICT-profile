using ICT_profile.Data;

namespace ICT_profile.Repos;

public interface IOtherExperiencesRepo
{
    IEnumerable<OtherExperienc> GetOthers(Guid id);
}
