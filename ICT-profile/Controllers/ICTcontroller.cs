using ICT_profile.Data;
using ICT_profile.Manegers;
using ICT_profile.View_Models;
using Microsoft.AspNetCore.Mvc;

namespace ICT_profile.Controllers;

public class ICTController : Controller
{
    private readonly IUserManeger _userManeger;
    public ICTController(IUserManeger userManeger)
    {
        _userManeger = userManeger;
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
}
