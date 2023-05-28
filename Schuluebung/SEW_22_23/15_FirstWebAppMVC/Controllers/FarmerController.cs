using _15_FirstWebAppMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace _15_FirstWebAppMVC.Controllers
{
	public class FarmerController : Controller
	{
		private FarmerModel model = new FarmerModel();

		public FarmerController()
		{
			model.Farmers.Add(new Farmer() { FirstName = "Jakob", LastName = "Prem", Address = "Steiermark ???", Birthday = new DateTime(2004, 9, 9), Id = 1 });
			model.Farmers.Add(new Farmer() { FirstName = "Johannes", LastName = "Werner", Address = "Gallbrunn", Birthday = new DateTime(2005, 4, 22), Id = 2 });
			model.Farmers.Add(new Farmer() { FirstName = "Alexander", LastName = "Stranz", Address = "Raach", Birthday = new DateTime(2004, 10, 2), Id = 3 });
		}

		public IActionResult Index()
		{
			return View(model);
		}

		public IActionResult Detail(int id)
		{
			Farmer f = model.Farmers.Where(farmer => farmer.Id == id).FirstOrDefault();
			return View(f);
		}

		[HttpPost]
		public IActionResult Edit(int id, Farmer f)	// Databomdomg auf das Objekt f mit den Post-Daten
		{
			Farmer toEdit = model.Farmers.Where(farmer => farmer.Id == id).FirstOrDefault();

			// den Farmer toEdit mit den aktuellen Daten vom Browser (f) updaten.

            return RedirectToAction("Index");
		}
	}
}
