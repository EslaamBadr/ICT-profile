using ICT_profile.Data;

namespace ICT_profile.Repos;

public class OtherExperiencesRepo : IOtherExperiencesRepo
{
    private readonly ICTcontext _context;
    public OtherExperiencesRepo(ICTcontext context)
    {
        _context = context;
    }

    public IEnumerable<OtherExperienc> GetOthers(Guid id)
    {
        return _context.OtherExperiencs.Where(i=> i.UserId == id);
    }
}
