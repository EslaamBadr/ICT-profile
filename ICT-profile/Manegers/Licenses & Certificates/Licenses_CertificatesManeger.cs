using ICT_profile.Data;
using ICT_profile.Repos;

namespace ICT_profile.Manegers;

public class Licenses_CertificatesManeger : ILiecenses_CertificatesManeger
{
    private readonly ILicenses_CertificatesRepo _licensesRepo;
    public Licenses_CertificatesManeger(ILicenses_CertificatesRepo licensesRepo)
    {
        _licensesRepo = licensesRepo;
    }

    public IEnumerable<Licences_CertificatesReadVM> GetCertificates(Guid id)
    {
        IEnumerable<Licenses_Certificates> licenses = _licensesRepo.GetLicenses(id);
        IEnumerable<Licences_CertificatesReadVM> licensesVM = licenses
            .Select(l => new Licences_CertificatesReadVM
            {
                Name = l.Name,
                Description = l.Description
            });
        return licensesVM;
    }
}

    
