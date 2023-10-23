using ICT_profile.Data;

namespace ICT_profile.Repos;

public interface IWorkExperienceRepo
{
    IEnumerable<WorkExperience>? GetWorkExperience(Guid id);
}
