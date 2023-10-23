using ICT_profile.Data;

namespace ICT_profile.Manegers;

public interface ILiecenses_CertificatesManeger
{
    IEnumerable<Licences_CertificatesReadVM> GetCertificates(Guid id);
}
