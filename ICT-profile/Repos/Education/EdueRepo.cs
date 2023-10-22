using ICT_profile.Data;

namespace ICT_profile.Repos;

public class EdueRepo : IEdueRepo
{
    ICTcontext _context;
    public EdueRepo(ICTcontext context)
    {
        _context = context;
    }

    Education? IEdueRepo.GetEdue(int id)
    {
        return _context.Educations.Find(id);
    }

    IEnumerable<Education> IEdueRepo.GetEdues()
    {
        return _context.Educations;
    }
}
