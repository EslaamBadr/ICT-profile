using ICT_profile.Data;

namespace ICT_profile.Repos;

public class UserRepo : IUserRepo
{
    ICTcontext _context;
    public UserRepo(ICTcontext context)
    {
        _context = context;
    }
}
