namespace ICT_profile.Data;

public class WorkExperienceReadVM
{
    public Guid? UserId { get; set; }
    public int Id { get; set; }
    public string RoleName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime StartDate { get; set; } = DateTime.Now;
    public DateTime EndDate { get; set; } = DateTime.Now;
    public string CompanyImage { get; set; } = string.Empty;
    public string CompanyName { get; set; } = string.Empty;
}
