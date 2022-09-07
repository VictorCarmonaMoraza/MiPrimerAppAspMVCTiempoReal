using MiPrimerAppAspMVCTiempoReal.Clases;
using MiPrimerAppAspMVCTiempoReal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Web;
using System.Web.Mvc;

namespace MiPrimerAppAspMVCTiempoReal.Controllers
{
    public class CategoriaCursoController : Controller
    {

        // GET: CategoriaCurso
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult listarCategoriaCurso()
        {
            //Inicializamos la lista
            List<CategoriaCursoCLS> lista = new List<CategoriaCursoCLS>();

            //Conectamos a BBDD
            using(BDCursoEntities bd=new BDCursoEntities())
            {
                lista = bd.CategoriaCurso.Select(p => new CategoriaCursoCLS
                {
                    IdCategoriaCurso = p.IIDCATEGORIACURSO,
                    Nombre = p.NOMBRE
                }).ToList();
            }
            return Json(lista, JsonRequestBehavior.AllowGet);
        }
    }
}