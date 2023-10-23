using ICT_profile.Data;
using ICT_profile.Repos;

namespace ICT_profile.Manegers;

public class EdueManeger : IEdueManeger
{
    private readonly IEdueRepo _edueRepo;
    public EdueManeger(IEdueRepo edueRepo)
    {
        _edueRepo = edueRepo;
    }
    //public EducationReadVM? GetEdue(int id)
    //{
    //    Education? edue = _edueRepo.GetEdue(id);
    //    if (edue == null)
    //    {
    //        return null;
    //    }
    //    return new EducationReadVM
    //    {
    //        UniverstyName = edue.UniverstyName,
    //        FacultyName = edue.FacultyName,
    //        UniverstyImage = edue.UniverstyImage,
    //        StartDate = edue.StartDate,
    //        EndDate = edue.EndDate
    //    };
    //}

    public IEnumerable<EducationReadVM> GetEdues(Guid id)
    {
        IEnumerable<Education> edues = _edueRepo.GetEdues(id);
        IEnumerable<EducationReadVM> eduesVM = edues
            .Select(e => new EducationReadVM
            {
                UniverstyName = e.UniverstyName,
                FacultyName = e.FacultyName,
                UniverstyImage = e.UniverstyImage,
                StartDate = e.StartDate,
                EndDate = e.EndDate
            });
        return eduesVM;
    }
}
