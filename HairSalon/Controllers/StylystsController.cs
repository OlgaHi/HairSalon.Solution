using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;

namespace HairSalon.Controllers
{
  public class StylystsController : Controller
  {
    private readonly HairSalonContext _db;
    public StylystsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Stylyst> model = _db.Stylysts.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Stylyst stylyst)
    {
      _db.Stylysts.Add(stylyst);
      _db.SaveChanges();
      return RedirectToAction("Index");
    } 

    public ActionResult Details(int id)
    {
    Stylyst thisStylyst = _db.Stylysts.FirstOrDefault(stylyst => stylyst.StylystId == id);
    return View(thisStylyst);
    }
  }
}