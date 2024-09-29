using WebApi.Model;

public class Client
{
    public long Id { get; set; }
    public required string Name { get; set; }
    public string Address { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
}
