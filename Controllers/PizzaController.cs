using la_mia_pizzeria_static.Data;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            PizzaDbContext db = new PizzaDbContext();

            List<Pizza> pizzaList = db.Pizzas.ToList();

            return View(pizzaList);
        }

        public IActionResult Show(int id)
        {
            PizzaDbContext db = new PizzaDbContext();

            Pizza pizza = db.Pizzas.Where(p => p.Id == id).FirstOrDefault();  

            return View(pizza);
        }

    }
}
