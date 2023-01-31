using Microsoft.AspNetCore.Mvc;

namespace Lab11_Misyuro.Kirill_MVC.Controllers;

public class Users : Controller
{
    // static UsersModel listusers = new UsersModel();
    // GET
    public IActionResult Index()
    {
        
        return View(listusers);
    }

    // [HttpGet]
    // public IActionResult AddUser(string name, string surname, string gender, int age ,string email)
    // {
    //     listusers.AddUser(name, surname, gender, age,email);
    //     return RedirectToAction("Index");
    // }
    public IActionResult AddUser(User user)
    {
        var listusers = new UsersModel();
        listusers.AddUser(user);
        return RedirectToAction("Index");
    }
}