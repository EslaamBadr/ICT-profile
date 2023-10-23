using ICT_profile.Data;

namespace ICT_profile.Manegers;

public interface IOtherExperiencesManeger
{
    IEnumerable<OtherExperienceReadVM> GetOthers(Guid id);
}
