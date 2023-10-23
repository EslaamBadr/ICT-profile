using ICT_profile.Data;

namespace ICT_profile.Repos;

public interface ILicenses_CertificatesRepo
{
    IEnumerable<Licenses_Certificates> GetLicenses(Guid id);
}
