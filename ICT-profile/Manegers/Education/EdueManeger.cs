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

    public IEnumerable<EducationReadVM> GetEdues(Guid id)
    {
        IEnumerable<Education> edues = _edueRepo.GetEdues(id);
        IEnumerable<EducationReadVM> eduesVM = edues
            .Select(e => new EducationReadVM
            {
                UserId = (Guid)e.UserId,
                Id = e.Id,
                UniverstyName = e.UniverstyName,
                FacultyName = e.FacultyName,
                UniverstyImage = e.UniverstyImage,
                StartDate = e.StartDate,
                EndDate = e.EndDate
            });
        return eduesVM;
    }

    public EducationUpdateVM GetEducation(int id)
    {
        Education education = _edueRepo.GetEducation(id);
        if (education == null)
        {
            return null;
        }
        return new EducationUpdateVM
        {
            Id = education.Id,
            UserId = (Guid)education.UserId,
            UniverstyName= education.UniverstyName,
            UniverstyImage= education.UniverstyImage,
            FacultyName= education.FacultyName,
            StartDate= education.StartDate,
            EndDate= education.EndDate,
        };
    }

    void IEdueManeger.UpdateUserEducation(EducationUpdateVM educationUpdateVM)
    {
        Education education = _edueRepo.GetEducation(educationUpdateVM.Id);
        if (education == null)
        {
            return;
        }
        education.UniverstyImage = educationUpdateVM.UniverstyImage;
        education.UniverstyName = educationUpdateVM.UniverstyName;
        education.StartDate = educationUpdateVM.StartDate;
        education.EndDate = educationUpdateVM.EndDate;
        education.FacultyName = educationUpdateVM.FacultyName;
        _edueRepo.UpdateUserEducation(education);
        _edueRepo.SaveChanges();
    }
}
