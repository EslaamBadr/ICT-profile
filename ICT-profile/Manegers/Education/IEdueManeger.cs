using ICT_profile.Data;

namespace ICT_profile.Manegers;

public interface IEdueManeger
{
    IEnumerable<EducationReadVM> GetEdues(Guid id);
    EducationUpdateVM GetEducation(int id);
    void UpdateUserEducation(EducationUpdateVM educationUpdateVM);
}
