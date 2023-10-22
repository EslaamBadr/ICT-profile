using ICT_profile.View_Models;

namespace ICT_profile.Manegers;

public interface IUserManeger
{
    UserReadVM? GetUser (Guid id);
    void UpdateUser(UserUpdateVM userUpdateVM);
}
