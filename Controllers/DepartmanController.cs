using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonelMVC.Models;
using PersonelMVC.ViewModels;

namespace PersonelMVC.Controllers
{
    public class DepartmanController : Controller
    {
        public ActionResult Detay(int id)
        {
            var departman = new Departman() { Id = id, Ad = "Bilgi işlem" };
            var personeller = new List<Personel>()
            {
                new Personel() { Ad = "Personel1"},
                new Personel() { Ad = "Personel2"},
                new Personel() { Ad = "Personel3"}
            };
            var model = new DepartmanDetayViewModel()
            {
                Departman = departman,
                Personeller = personeller
            };
            return View(model);
        }


    }

}