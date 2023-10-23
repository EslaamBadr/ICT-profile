using ICT_profile.Data;
using ICT_profile.Repos;

namespace ICT_profile.Manegers;

public class SkillsManeger : ISkillsManeger
{
    private readonly ISkillsRepo _skillsRepo;
    public SkillsManeger(ISkillsRepo skillsRepo)
    {
        _skillsRepo = skillsRepo;
    }

    public IEnumerable<SKillReadVM> GetSkills(Guid id)
    {
        IEnumerable<Skill> skills = _skillsRepo.GetSkills(id);
        IEnumerable<SKillReadVM> skillVM = skills
            .Select(s => new SKillReadVM
            {
                Name = s.Name
            });
        return skillVM;
    }
}
