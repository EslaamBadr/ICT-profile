using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ICT_profile.Data;

public class User
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }= string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public string JobTitle { get; set; } = string.Empty;
    public Contact? Contact { get; set; }
    public About? About { get; set; }
    public IEnumerable<WorkExperience> Experiences { get; set; } = new List<WorkExperience>();
    public IEnumerable<Education> Educations { get; set; } = new List<Education>();
    public IEnumerable<Licenses_Certificates> Licenses_Certificatess { get; set; } = new List<Licenses_Certificates>();
    public IEnumerable<Skill> Skills { get; set; } = new List<Skill>();
    public IEnumerable<OtherExperienc> OtherExperiencs { get; set; } = new List<OtherExperienc>();
    public IEnumerable<Accomplishment> Accomplishments { get; set; } = new List<Accomplishment>();

}
