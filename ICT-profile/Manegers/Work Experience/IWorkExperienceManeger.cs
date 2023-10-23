using ICT_profile.Data;

namespace ICT_profile.Manegers;

public interface IWorkExperienceManeger
{
    IEnumerable<WorkExperienceReadVM> GetExperience(Guid id);
}
