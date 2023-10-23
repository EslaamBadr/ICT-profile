using ICT_profile.Data;

namespace ICT_profile.Repos;

public class AboutRepo : IAboutRepo
{
    ICTcontext _context;
    public AboutRepo(ICTcontext context)
    {
        _context = context;
    }

    public About? GetAbout(Guid id)
    {
        return _context.Users.Where(a => a.Id == id).Select(a => a.About).FirstOrDefault();
        //return _context.About.Find(id);
    }
}
