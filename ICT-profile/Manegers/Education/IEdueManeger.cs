using ICT_profile.Data;

namespace ICT_profile.Manegers;

public interface IEdueManeger
{
    EducationReadVM? GetEdue(int id);
    IEnumerable<EducationReadVM> GetEdues();
}
