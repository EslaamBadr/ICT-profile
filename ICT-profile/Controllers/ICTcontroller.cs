using ICT_profile.Data;
using ICT_profile.Manegers;
using ICT_profile.View_Models;
using Microsoft.AspNetCore.Mvc;

namespace ICT_profile.Controllers;

public class ICTController : Controller
{
    private readonly IUserManeger _userManeger;
    private readonly IAboutManeger _aboutManeger;
    private readonly IContactManeger _contactManeger;
    private readonly IWorkExperienceManeger _workExperienceManeger;
    private readonly IEdueManeger _edueManeger;
    private readonly ILiecenses_CertificatesManeger _licensesManeger;
    private readonly IOtherExperiencesManeger _othersManeger;
    private readonly ISkillsManeger _skillsManeger;
    private readonly IAccomplishmentManeger _accomplishmentManeger;
    public ICTController(IUserManeger userManeger, IAboutManeger aboutManeger, 
        IContactManeger contactManeger, IWorkExperienceManeger workExperienceManeger,
        IEdueManeger edueManeger, ILiecenses_CertificatesManeger licensesManeger
        , IOtherExperiencesManeger othersManeger, ISkillsManeger skillsManeger, IAccomplishmentManeger accomplishmentManeger)
    {
        _userManeger = userManeger;
        _aboutManeger = aboutManeger;
        _contactManeger = contactManeger;
        _workExperienceManeger = workExperienceManeger;
        _edueManeger = edueManeger;
        _licensesManeger = licensesManeger;
        _othersManeger = othersManeger;
        _skillsManeger = skillsManeger;
        _accomplishmentManeger = accomplishmentManeger;
    }

    public IActionResult Dashboard()
    {
        return View();
    }

    [HttpGet]
    public IActionResult UserInfo(Guid id)
    {
        UserReadVM? user = _userManeger.GetUser(id);
        return View(user);
    }

    [HttpPut]
    public IActionResult Update(UserUpdateVM userUpdateVM)
    {
        _userManeger.UpdateUser(userUpdateVM);
        return RedirectToAction("Index");
    }

    public IActionResult Profile(Guid id)
    {
        FullView fullView = new FullView();
        string sId = "c89c5837-3f1b-4ed2-b082-2de51b6202c6";
        UserReadVM? user = _userManeger.GetUser(Guid.Parse(sId));
        AboutReadVM about = _aboutManeger.GetAbout(Guid.Parse(sId));
        ContactReadVM? contact = _contactManeger.GetContact(Guid.Parse(sId));
        IEnumerable<WorkExperienceReadVM>? experiences = _workExperienceManeger.GetExperience(Guid.Parse(sId));
        IEnumerable<EducationReadVM>? educations = _edueManeger.GetEdues(Guid.Parse(sId));
        IEnumerable<Licences_CertificatesReadVM> licenses = _licensesManeger.GetCertificates(Guid.Parse(sId));
        IEnumerable<OtherExperienceReadVM> others = _othersManeger.GetOthers(Guid.Parse(sId));
        IEnumerable<SKillReadVM> skills = _skillsManeger.GetSkills(Guid.Parse(sId));
        IEnumerable<AccomplishmentReadVM> accomplishments = _accomplishmentManeger.GetAccomplishments(Guid.Parse(sId));
        
        fullView.User = user;
        fullView.About = about;
        fullView.Contact = contact;
        fullView.WorkExperiences = experiences;
        fullView.Educations = educations;
        fullView.Licenses = licenses;
        fullView.OtherExperiencs = others;
        fullView.Skills = skills;
        fullView.Accomplishment = accomplishments;
        return View(fullView);
    }
}
