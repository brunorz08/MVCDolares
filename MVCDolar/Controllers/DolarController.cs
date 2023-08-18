using APIDolar.Models;
using Microsoft.AspNetCore.Mvc;
using MVCDolar.Models.Dolares;

namespace MVCDolar.Controllers
{

    public class DolarController : Controller
    {
        private readonly API _api;

        public DolarController(API api)
        {
            _api = api;
        }

        public async Task<IActionResult> Index()
        {
           List<Casas2> casaList = await API.ObtenerCasas();
            Dolares dolar = await API.ObtenerDolares();
            ViewBag.CasasList = casaList;
            ViewBag.Dolar = dolar;

            return View();
        }

      
    }
}
