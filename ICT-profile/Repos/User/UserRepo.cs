using ICT_profile.Data;

namespace ICT_profile.Repos;

public class UserRepo : IUserRepo
{
    ICTcontext _context;
    public UserRepo(ICTcontext context)
    {
        _context = context;
    }

    IEnumerable<User> IUserRepo.GetUsers()
    {
        return _context.Users;
    }

    public User? GetUser(Guid id)
    {
        return _context.Users.Find(id);
    }

    public void UpdateUser(User user)
    {
        _context.Users.Update(user);
        //SaveChanges();
    }

    void IUserRepo.DeleteUser(User user)
    {
        _context.Users.Remove(user);
    }

    void IUserRepo.AddUser(User user)
    {
        _context.Users.Add(user);
    }

    public int SaveChanges()
    {
        return _context.SaveChanges();
    }
}
