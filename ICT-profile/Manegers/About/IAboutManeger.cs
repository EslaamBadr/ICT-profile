using ICT_profile.Data;

namespace ICT_profile.Manegers;

public interface IAboutManeger
{
    AboutReadVM? GetAbout(Guid id);
    AboutUpdateVM? GetAboutToUpdate(Guid id);
}
