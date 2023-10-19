namespace ICT_profile.Data;

public class Accomplishment
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime AccomplishDate { get; set; }

    public User? User { get; set; }
    public Guid? UserId { get; set; }
}
