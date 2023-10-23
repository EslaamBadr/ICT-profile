using ICT_profile.Data;

namespace ICT_profile.Repos;

public class SkillsRepo : ISkillsRepo
{
    private readonly ICTcontext _context;
    public SkillsRepo(ICTcontext context)
    {
        _context = context;
    }

    public IEnumerable<Skill> GetSkills(Guid id)
    {
        return _context.Skills.Where(i=> i.UserId == id);
    }
}
