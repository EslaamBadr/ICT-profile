using ICT_profile.Data;

namespace ICT_profile.Repos;

public class AccomplishmentRepo : IAccomplishmentRepo
{
    private readonly ICTcontext _context;
    public AccomplishmentRepo(ICTcontext context)
    {
        _context = context;
    }

    public IEnumerable<Accomplishment> GetAccomplishments(Guid id)
    {
        return _context.Accomplishments.Where(i=> i.UserId == id);
    }
}
