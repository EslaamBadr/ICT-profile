using ICT_profile.Data;

namespace ICT_profile.Manegers;

public interface IWorkExperienceManeger
{
    IEnumerable<WorkExperienceReadVM>? GetExperiences(Guid id);
    WorkExperienceUpdateVM GetExperience(int id);
    void UpdateUserWorkExperience (WorkExperienceUpdateVM experienceUpdateVM);

    void AddUserWorkExperience(WorkExperienceReadVM experienceVM);
}
