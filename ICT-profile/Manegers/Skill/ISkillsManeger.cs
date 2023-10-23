using ICT_profile.Data;

namespace ICT_profile.Manegers;

public interface ISkillsManeger
{
    IEnumerable<SKillReadVM> GetSkills(Guid id);
}
