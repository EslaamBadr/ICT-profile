using ICT_profile.Data;
using ICT_profile.Repos;

namespace ICT_profile.Manegers;

public class OtherExperiencesManeger : IOtherExperiencesManeger
{
    private readonly IOtherExperiencesRepo _othersRepo;
    public OtherExperiencesManeger(IOtherExperiencesRepo othersRepo)
    {
        _othersRepo = othersRepo;
    }

    public IEnumerable<OtherExperienceReadVM> GetOthers(Guid id)
    {
        IEnumerable<OtherExperienc> others = _othersRepo.GetOthers(id);
        IEnumerable<OtherExperienceReadVM> othersVM = others
            .Select(l => new OtherExperienceReadVM
            {
                Name = l.Name,
                Description = l.Description
            });
        return othersVM;
    }
}
