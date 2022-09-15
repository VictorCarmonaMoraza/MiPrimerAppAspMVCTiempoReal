using MiPrimerAppAspMVCTiempoReal.Clases;
using MiPrimerAppAspMVCTiempoReal.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MiPrimerAppAspMVCTiempoReal.Controllers
{
    public class CursoController : Controller
    {
        // GET: Curso
        public ActionResult Index()
        {
            return View();n
        }

        public JsonResult listarCursos()
        {
            List<CursoCLS> lista = new List<CursoCLS>();
            using(BDCursoEntities bd=new BDCursoEntities())
            {
                lista = (from curso in bd.Curso
                        join categoriacurso in bd.CategoriaCurso
                        on curso.IIDCATEGORIACURSO equals categoriacurso.IIDCATEGORIACURSO
                        select new CursoCLS
                        {
                            IdCurso= curso.IIDCURSO,
                            NombreCurso = curso.NOMBRE,
                            NombreCategoria= categoriacurso.NOMBRE,
                            Precio = curso.PRECIO
                        }).ToList();
            }
            return Json(lista,JsonRequestBehavior.AllowGet);
        }
    }
}