using ICT_profile.Data;

namespace ICT_profile.Repos;

public interface ISkillsRepo
{
    IEnumerable<Skill> GetSkills(Guid id);
}
