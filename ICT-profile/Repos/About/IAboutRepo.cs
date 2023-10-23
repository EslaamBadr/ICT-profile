using ICT_profile.Data;

namespace ICT_profile.Repos;

public interface IAboutRepo
{
    About? GetAbout(Guid id);
}
