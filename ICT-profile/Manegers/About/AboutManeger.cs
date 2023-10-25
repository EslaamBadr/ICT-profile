using ICT_profile.Data;
using ICT_profile.Repos;
using ICT_profile.View_Models;

namespace ICT_profile.Manegers;

public class AboutManeger : IAboutManeger
{
    private readonly IAboutRepo _abouteRepo;
    public AboutManeger(IAboutRepo abouteRepo)
    {
        _abouteRepo = abouteRepo;
    }

    public AboutReadVM GetAbout(Guid id)
    {
        About? about = _abouteRepo.GetAbout(id);
            if (about is  null) 
            {
                return null;
            }
        return new AboutReadVM
        {
            AboutUser = about.AboutUser
        };
    }

    public AboutUpdateVM? GetAboutToUpdate(Guid id)
    {
        About? about = _abouteRepo.GetAbout(id);
        if (about is null)
        {
            return null;
        }

        return new AboutUpdateVM
        {
            UserId = (Guid)about.UserId,
            Id = about.Id,
            AboutUser = about.AboutUser
        };
    }

    public void UpdateUserAbout(AboutUpdateVM aboutUpdateVM)
    {
        About? about = _abouteRepo.GetAbout(aboutUpdateVM.UserId);
        if (about == null)
        {
            return;
        }
        about.AboutUser = aboutUpdateVM.AboutUser;
        _abouteRepo.UpdateUserAbout(about);
        _abouteRepo.SaveChanges();
    }
}
