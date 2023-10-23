using ICT_profile.Data;

namespace ICT_profile.Manegers;

public interface IAccomplishmentManeger
{
    IEnumerable<AccomplishmentReadVM> GetAccomplishments(Guid id);
}
