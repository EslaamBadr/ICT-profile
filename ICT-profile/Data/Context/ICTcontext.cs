using Microsoft.EntityFrameworkCore;

namespace ICT_profile.Data;

public class ICTcontext : DbContext
{
    public DbSet<User> Users => Set<User>();

    public ICTcontext(DbContextOptions<ICTcontext> options) : base(options)
    {

    }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    base.OnConfiguring(optionsBuilder);
    //    optionsBuilder.UseSqlServer("");
    //}
}
