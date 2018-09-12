using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tamagotchis.Models;

namespace Tamagotchis.Controllers
{
  public class TamagotchiController : Controller
  {
    [HttpGet("/tamas")]
    public ActionResult Index()
    {
      List<Tamagotchi> allTamas = Tamagotchi.GetAll();
      return View(allTamas);
    }

    [HttpGet("/tamas/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    [HttpPost("/tamas")]
    public ActionResult Create()
    {
      Tamagotchi newTamagotchi = new Tamagotchi(Request.Form["new-name"]);
      List<Tamagotchi> allTamas = Tamagotchi.GetAll();
      return View("Index",allTamas);
    }

    [HttpGet("/tamas/{id}")]
    public ActionResult Details(int id)
    {
      Tamagotchi newTama = Tamagotchi.Find(id);
      return View(newTama);
    }

    [HttpGet("/tamas/delete/{tamaToBeDeleted}")]
    public ActionResult Delete(string tamaToBeDeleted)
    {
      return View(tamaToBeDeleted);
    }

    [HttpPost("/tamas/delete/{id}")]
    public ActionResult DeleteTama(int id)
    {
      Tamagotchi newTama = Tamagotchi.Find(id);
      string tamaToBeDeleted = newTama.name;
      Tamagotchi.Delete(newTama);
      return View("Delete", tamaToBeDeleted);
    }

    [HttpPost("/tamas/feed/{id}")]
    public ActionResult Feed(int id)
    {
        Tamagotchi newTamagotchi = Tamagotchi.Find(id);
        newTamagotchi.Feed();
        return View(newTamagotchi);
    }
    [HttpPost("/tamas/play/{id}")]
    public ActionResult Play(int id)
    {
        Tamagotchi newTamagotchi = Tamagotchi.Find(id);
        newTamagotchi.Play();
        return View(newTamagotchi);
    }
    [HttpPost("/tamas/rest/{id}")]
    public ActionResult Rest(int id)
    {
        Tamagotchi newTamagotchi = Tamagotchi.Find(id);
        newTamagotchi.Sleep();
        return View(newTamagotchi);
    }
  }
}
