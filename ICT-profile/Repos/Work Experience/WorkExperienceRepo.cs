using ICT_profile.Data;

namespace ICT_profile.Repos;

public class WorkExperienceRepo : IWorkExperienceRepo
{
    private readonly ICTcontext _context;
    public WorkExperienceRepo(ICTcontext context)
    {
        _context = context;
    }

    public IEnumerable<WorkExperience>? GetWorkExperience(Guid id)
    {
        return _context.Experiences.Where(e=> e.UserId == id);
    }
}
