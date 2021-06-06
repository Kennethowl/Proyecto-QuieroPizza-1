using QuieroPizza.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuieroPizza.web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var ListadeProductos = new List<ProductoModel>();

            var producto1 = new ProductoModel();
            producto1.Codigo = 001;
            producto1.Descripcion = "Pizza Season's Queen";
            ListadeProductos.Add(producto1);

            var producto2 = new ProductoModel();
            producto2.Codigo = 002;
            producto2.Descripcion = "Cheese Supreme";
            ListadeProductos.Add(producto2);

            var producto3 = new ProductoModel();
            producto3.Codigo = 003;
            producto3.Descripcion = "Lasagna de Carne Molida";
            ListadeProductos.Add(producto3);

            return View(ListadeProductos);
        }
    }
}