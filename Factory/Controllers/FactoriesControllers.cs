// using Microsoft.AspNetCore.Mvc.Rendering;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.AspNetCore.Mvc;
// using Factory.Models;
// using System.Collections.Generic;
// using System.Linq;

// namespace Factory.Controllers
// {
//   public class FactoriesController : Controller
// {
//     private readonly FactoryContext _db;
//     public FactoriesController(FactoryContext db)
//     {
//       _db = db;
//     }
//     public ActionResult Index()
//     {
//       List<Factory> model = _db.Factories.ToList();
//       return View(model);
//     }

//   }
// }