using ICT_profile.Data;

namespace ICT_profile.Repos;

public interface IWorkExperienceRepo
{
    IEnumerable<WorkExperience>? GetAllExperiences(Guid id);
    WorkExperience GetWorkExperience(int id);
    void UpdateUserWorkExperience(WorkExperience experience);
    int SaveChanges();
}
