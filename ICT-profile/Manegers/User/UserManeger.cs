using ICT_profile.Data;
using ICT_profile.Repos;
using ICT_profile.View_Models;
using System.Numerics;

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

    public UserUpdateVM? GetUserForUpdate(Guid id)
    {
        User? user = _userRepo.GetUser(id);
            if (user is null)
        {
            return null;
        }

        return new UserUpdateVM
        {
            Id = id,
            FirstName = user.FirstName,
            LastName = user.LastName,
            JobTitle = user.JobTitle,
            Image = user.Image
        };
    }

    public void UpdateUser(UserUpdateVM userUpdateVM)
    {
        User? user =_userRepo.GetUser(userUpdateVM.Id);
        if (user == null)
        {
            return;
        }
        user.FirstName = userUpdateVM.FirstName;
        user.LastName = userUpdateVM.LastName;
        user.JobTitle = userUpdateVM.JobTitle;
        _userRepo.UpdateUser(user);
        _userRepo.SaveChanges();
    }

}
