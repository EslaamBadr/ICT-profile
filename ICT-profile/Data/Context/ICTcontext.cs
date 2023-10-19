using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Reflection.Emit;

namespace ICT_profile.Data;

public class ICTcontext : DbContext
{
    public DbSet<User> Users => Set<User>();
    public DbSet<Contact> Contacts => Set<Contact>();
    public DbSet<Education> Educations => Set<Education>();
    public DbSet<WorkExperience> Experiences => Set<WorkExperience>();
    public DbSet<Licenses_Certificates> Licenses_Certificatess => Set<Licenses_Certificates>();
    public DbSet<OtherExperienc> OtherExperiencs => Set<OtherExperienc>();
    public DbSet<Skill> Skills => Set<Skill>();
    public DbSet<Accomplishment> Accomplishments => Set<Accomplishment>();


    public ICTcontext(DbContextOptions<ICTcontext> options) : base(options)
    {

    }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    base.OnConfiguring(optionsBuilder);
    //    optionsBuilder.UseSqlServer("");
    //}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contact>().HasKey(k => k.Email);

        modelBuilder.Entity<User>()
            .HasOne(c => c.Contact)
            .WithOne(u => u.User);

        modelBuilder.Entity<User>()
            .HasMany(e => e.Educations)
            .WithOne(u => u.User)
            .HasForeignKey(i => i.UserId);

        modelBuilder.Entity<User>()
            .HasMany(e => e.Experiences)
            .WithOne(u => u.User)
            .HasForeignKey(i => i.UserId);

        modelBuilder.Entity<User>()
            .HasMany(s => s.Skills)
            .WithOne(u => u.User)
            .HasForeignKey(i => i.UserId);

        modelBuilder.Entity<User>()
            .HasMany(a => a.Accomplishments)
            .WithOne(u => u.User)
            .HasForeignKey(i => i.UserId);

        modelBuilder.Entity<User>()
            .HasMany(l => l.Licenses_Certificatess)
            .WithOne(u => u.User)
            .HasForeignKey(i => i.UserId);

        modelBuilder.Entity<User>()
            .HasMany(o => o.OtherExperiencs)
            .WithOne(u => u.User)
            .HasForeignKey(i => i.UserId);
    }
}
