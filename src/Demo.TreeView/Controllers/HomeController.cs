using Demo.TreeView.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace Demo.TreeView.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var dados = Dados.GetGerentes;
            return View(dados);
        }

        [HttpPost]
        public PartialViewResult Lojas(string gerentes)
        {
            
            if (Request.IsAjaxRequest())
            {
                var view = "_lojas";
                int[] array = gerentes.Split(',').Select(n => Convert.ToInt32(n)).ToArray();
                var dados = Dados.GetLojas(array);

                return PartialView(view, dados);
            }

            return null;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Demo Treeview";

            return View();
        }

    }

    
}