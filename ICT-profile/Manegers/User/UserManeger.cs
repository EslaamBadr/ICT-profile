using ICT_profile.Data;
using ICT_profile.Repos;
using ICT_profile.View_Models;

namespace ICT_profile.Manegers;

public class UserManeger : IUserManeger
{
    private readonly IUserRepo _userRepo;
    public UserManeger(IUserRepo userRepo)
    {
         _userRepo = userRepo;
    }
    public UserReadVM? GetUser(Guid id)
    {
        User? user = _userRepo.GetUser(id);
        if (user == null)
        {
            return null;
        }
        return new UserReadVM
        {
            FirstName = user.FirstName,
            LastName = user.LastName,
            JobTitle = user.JobTitle,
            Image = user.Image
        };
    }

    public void UpdateUser(UserUpdateVM userUpdateVM)
    {
        var user = new User
        {
            FirstName = userUpdateVM.FirstName,
            LastName = userUpdateVM.LastName,
            JobTitle = userUpdateVM.JobTitle,
            Image = userUpdateVM.Image
        };
        _userRepo.UpdateUser(user);
    }
}
