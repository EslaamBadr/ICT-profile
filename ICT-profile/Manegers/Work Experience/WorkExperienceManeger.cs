using ICT_profile.Data;
using ICT_profile.Repos;

namespace ICT_profile.Manegers;

public class WorkExperienceManeger : IWorkExperienceManeger
{
    private readonly IWorkExperienceRepo _experienceRepo;
    public WorkExperienceManeger(IWorkExperienceRepo experienceRepo)
    {
        _experienceRepo = experienceRepo;
    }

    public IEnumerable<WorkExperienceReadVM> GetExperience(Guid id)
    {
        IEnumerable<WorkExperience>? experiencesDb = _experienceRepo.GetWorkExperience(id);
        if (experiencesDb == null)
        {
            return null;
        }
        IEnumerable<WorkExperienceReadVM> experiencesVM = experiencesDb
            .Select(d => new WorkExperienceReadVM
            {
                RoleName = d.RoleName,
                Description = d.Description,
                StartDate = d.StartDate,
                EndDate = d.EndDate,
                CompanyImage = d.CompanyImage,
                CompanyName = d.CompanyName
            });

        return experiencesVM;
    }
}
