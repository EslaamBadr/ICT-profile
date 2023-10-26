using ICT_profile.Data;

namespace ICT_profile.Repos;

public interface IEdueRepo
{
    IEnumerable<Education> GetEdues(Guid id);
    Education GetEducation(int id);
    void UpdateUserEducation(Education education);
    void AddUserEducation(Education educaion);
    int SaveChanges();
}
