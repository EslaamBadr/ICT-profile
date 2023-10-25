using ICT_profile.Data;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace ICT_profile.Repos;

public class WorkExperienceRepo : IWorkExperienceRepo
{
    private readonly ICTcontext _context;
    public WorkExperienceRepo(ICTcontext context)
    {
        _context = context;
    }

    public IEnumerable<WorkExperience>? GetAllExperiences(Guid id)
    {
        return _context.Experiences.Where(e => e.UserId == id);
    }

    public WorkExperience GetWorkExperience(int id)
    {
        return _context.Experiences.Where(e=> e.Id==id).FirstOrDefault();
    }

    public void UpdateUserWorkExperience(WorkExperience experience)
    {
        _context.Experiences.Update(experience);
    }

    public void Add(WorkExperience experience)
    {
        _context.Experiences.Add(experience);
    }
    public int SaveChanges()
    {
        return _context.SaveChanges();
    }
}
