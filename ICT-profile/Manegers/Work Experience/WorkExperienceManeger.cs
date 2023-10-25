using ICT_profile.Data;
using ICT_profile.Repos;
using System.Numerics;

namespace ICT_profile.Manegers;

public class WorkExperienceManeger : IWorkExperienceManeger
{
    private readonly IWorkExperienceRepo _experienceRepo;
    public WorkExperienceManeger(IWorkExperienceRepo experienceRepo)
    {
        _experienceRepo = experienceRepo;
    }

    public IEnumerable<WorkExperienceReadVM> GetExperiences(Guid id)
    {
        IEnumerable<WorkExperience>? experiencesDb = _experienceRepo.GetAllExperiences(id);
        if (experiencesDb == null)
        {
            return null;
        }
        IEnumerable<WorkExperienceReadVM> experiencesVM = experiencesDb
            .Select(d => new WorkExperienceReadVM
            {
                Id = d.Id,
                UserId = d.UserId,
                RoleName = d.RoleName,
                Description = d.Description,
                StartDate = d.StartDate,
                EndDate = d.EndDate,
                CompanyImage = d.CompanyImage,
                CompanyName = d.CompanyName
            });

        return experiencesVM;
    }

    public WorkExperienceUpdateVM GetExperience(int id)
    {
        WorkExperience experiencesDb = _experienceRepo.GetWorkExperience(id);
        if (experiencesDb == null)
        {
            return null;
        }
        return new WorkExperienceUpdateVM
        {
            Id = experiencesDb.Id,
            UserId = experiencesDb.UserId,
            RoleName = experiencesDb.RoleName,
            Description = experiencesDb.Description,
            StartDate = experiencesDb.StartDate,
            EndDate = experiencesDb.EndDate,
            CompanyImage = experiencesDb.CompanyImage,
            CompanyName = experiencesDb.CompanyName
        };
    }

    public void UpdateUserWorkExperience(WorkExperienceUpdateVM experienceUpdateVM)
    {
        WorkExperience? experience = _experienceRepo.GetWorkExperience(experienceUpdateVM.Id);
        if (experience == null)
        {
            return;
        }
        experience.CompanyName = experienceUpdateVM.CompanyName;
        experience.CompanyImage = experienceUpdateVM.CompanyImage;
        experience.Description = experienceUpdateVM.Description;
        experience.StartDate = experienceUpdateVM.StartDate;
        experience.EndDate = experienceUpdateVM.EndDate;
        experience.RoleName = experienceUpdateVM.RoleName;
        _experienceRepo.UpdateUserWorkExperience(experience);
        _experienceRepo.SaveChanges();
    }

    public void AddUserWorkExperience(WorkExperienceReadVM experienceVM)
    {
        var experience = new WorkExperience
        {
            CompanyName = experienceVM.CompanyName,
            CompanyImage = experienceVM.CompanyImage,
            Description = experienceVM.Description,
            StartDate = experienceVM.StartDate,
            EndDate = experienceVM.EndDate,
            RoleName = experienceVM.RoleName,
        };

        _experienceRepo.Add(experience);
        _experienceRepo.SaveChanges();
    }
}
