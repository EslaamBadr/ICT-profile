using ICT_profile.Data;
using System.Numerics;

namespace ICT_profile.Repos;

public interface IWorkExperienceRepo
{
    IEnumerable<WorkExperience>? GetAllExperiences(Guid id);
    WorkExperience GetWorkExperience(int id);
    void UpdateUserWorkExperience(WorkExperience experience);
    void Add(WorkExperience experience);
    int SaveChanges();
}
