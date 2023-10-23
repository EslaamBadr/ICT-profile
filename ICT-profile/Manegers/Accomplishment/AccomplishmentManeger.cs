using ICT_profile.Data;
using ICT_profile.Repos;

namespace ICT_profile.Manegers;

public class AccomplishmentManeger : IAccomplishmentManeger
{
    private readonly IAccomplishmentRepo _accompRepo;
    public AccomplishmentManeger(IAccomplishmentRepo accompRepo)
    {
        _accompRepo = accompRepo;
    }

    public IEnumerable<AccomplishmentReadVM> GetAccomplishments(Guid id)
    {
        IEnumerable<Accomplishment> accomps = _accompRepo.GetAccomplishments(id);
        IEnumerable<AccomplishmentReadVM> accompsVM = accomps
            .Select(a => new AccomplishmentReadVM
            {
                Name = a.Name,
                AccomplishDate = a.AccomplishDate,
            });
        return accompsVM;
    }
}
