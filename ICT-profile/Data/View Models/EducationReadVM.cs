namespace ICT_profile.Data;

public class EducationReadVM
{
    public Guid UserId { get; set; }
    public int Id { get; set; }
    public string UniverstyName { get; set; } = string.Empty;
    public string FacultyName { get; set; } = string.Empty;
    public string UniverstyImage { get; set; } = string.Empty;
    public DateTime StartDate { get; set; } = DateTime.Now;
    public DateTime EndDate { get; set; } = DateTime.Now;
}
