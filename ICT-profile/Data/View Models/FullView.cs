using ICT_profile.View_Models;

namespace ICT_profile.Data;

public class FullView
{
    public UserReadVM? User { get; set; }
    public UserUpdateVM? UserUpdateVM { get; set; }
    public AboutReadVM? About { get; set; }
    public AboutUpdateVM? AboutUpdateVM { get; set; }
    public ContactReadVM? Contact { get; set; }
    public ContactUpdateVM? ContactUpdateVM { get; set; }
    public IEnumerable<EducationReadVM>? Educations { get; set; }
    public EducationUpdateVM? EducationUpdateVM { get; set; }
    public IEnumerable<WorkExperienceReadVM>? WorkExperiences { get; set;}
    public WorkExperienceUpdateVM? ExperienceUpdateVM { get; set; }
    public IEnumerable<OtherExperienceReadVM>? OtherExperiencs { get; set; }
    public IEnumerable<AccomplishmentReadVM>? Accomplishment { get; set;}
    public IEnumerable<Licences_CertificatesReadVM>? Licenses { get; set; }
    public IEnumerable<SKillReadVM>? Skills { get; set; }
}
