using ICT_profile.Data;
using ICT_profile.View_Models;

namespace ICT_profile.Manegers;

public interface IAboutManeger
{
    AboutReadVM? GetAbout(Guid id);
    AboutUpdateVM? GetAboutToUpdate(Guid id);
    void UpdateUserAbout(AboutUpdateVM aboutUpdateVM);
}
