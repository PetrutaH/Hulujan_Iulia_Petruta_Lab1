using Microsoft.AspNetCore.Mvc;

namespace Hulujan_Iulia_Petruta_Lab1.Controllers
{
    public class newController : Controller
    {
        public string Index()
        {
            return "Bun venit!";
        }

        public string Salut()
        {
            return "Salut!";
        }

        public string Mesaj(string nume, int varsta)
        {
            return $"Salut {nume}. Ai {varsta} ani.";
        }

    }
}
