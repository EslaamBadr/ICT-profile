using ICT_profile.Data;

namespace ICT_profile.Repos;

public interface IUserRepo
{
    IEnumerable<User> GetUsers();
    User? GetUser(Guid id);
    void UpdateUser(User user);
    void DeleteUser(User user);
    void AddUser(User user);
}
