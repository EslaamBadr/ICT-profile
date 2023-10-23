using ICT_profile.Controllers;
using ICT_profile.Data;

namespace ICT_profile.Repos;

public class Licenses_CertificatesRepo : ILicenses_CertificatesRepo
{
    private readonly ICTcontext _context;
    public Licenses_CertificatesRepo(ICTcontext conntext)
    {
        _context = conntext;
    }

    public IEnumerable<Licenses_Certificates> GetLicenses(Guid id)
    {
        return _context.Licenses_Certificatess.Where(i=> i.UserId == id);
    }
}
