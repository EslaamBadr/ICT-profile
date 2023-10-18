namespace ICT_profile.Data;

public class Education
{
    public int Id { get; set; }
    public string UniverstyName { get; set; } = string.Empty;
    public string FacultyName { get; set; } = string.Empty;
    public string UniverstyImage { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}
