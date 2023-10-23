using ICT_profile.Data;
using ICT_profile.Repos;

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
    
}
