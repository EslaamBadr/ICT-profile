using ICT_profile.Data;

namespace ICT_profile.Repos;

public interface IAccomplishmentRepo
{
    IEnumerable<Accomplishment> GetAccomplishments(Guid id);
}
