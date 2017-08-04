using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TiendaVirtual.Controllers
{
    public class HomeController : Controller
    {
        private Models.TiendaEntities bd = new Models.TiendaEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Buscar(string id="")
        {
            // logica de acceso a base de datos
            var productos = bd.Producto
                .Where(x => x.Denominacion.Contains(id))
                .Take(20)
                .ToList();
            //lista con los datos de la busqueda
            ViewBag.clave = id;
            return View(productos);
        }
    }
}
