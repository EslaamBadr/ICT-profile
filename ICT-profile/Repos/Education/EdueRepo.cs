using ICT_profile.Data;

namespace ICT_profile.Repos;

public class EdueRepo : IEdueRepo
{
    ICTcontext _context;
    public EdueRepo(ICTcontext context)
    {
        _context = context;
    }

public IEnumerable<Education> GetEdues(Guid id)
    {
        return _context.Educations.Where(e => e.UserId == id);
    }

    public Education GetEducation(int id)
    {
        return _context.Educations.Where(e => e.Id == id).FirstOrDefault();
    }

    public void UpdateUserEducation(Education education)
    {
        _context.Educations.Update(education);
    }
    public int SaveChanges()
    {
        return _context.SaveChanges();
    }   
}
