using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using APP_MARKEPLACE.Entity;
using APP_MARKEPLACE.Models;

namespace APP_MARKEPLACE.Controllers
{
    public class AfiliadoController : Controller
    {
        AfiliadoDL afiliadoDL = new AfiliadoDL();
        public ActionResult Listado_afiliado()
        {
            return View(afiliadoDL.Listado_afiliado());
        }

        public ActionResult Registrar_afiliado()
        {
            ViewBag.pais = new SelectList(afiliadoDL.Listado_pais(), "idpais", "descripcion");
            ViewBag.provincia = new SelectList(afiliadoDL.Listado_provincia(), "idprovincia", "nombre");
            ViewBag.distrito = new SelectList(afiliadoDL.Listado_distrito(), "iddistrito", "nombre");
            ViewBag.tipoEmpresa = new SelectList(afiliadoDL.Listado_tipoEmpresa(), "idtipo", "descripcion");
            return View(new Afiliado());
        }

        [HttpPost]
        public ActionResult Registrar_afiliado(Afiliado afi)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.pais = new SelectList(afiliadoDL.Listado_pais(), "idpais", "descripcion", afi.idpais);
                ViewBag.provincia = new SelectList(afiliadoDL.Listado_provincia(), "idprovincia", "nombre", afi.idprovincia);
                ViewBag.distrito = new SelectList(afiliadoDL.Listado_distrito(), "iddistrito", "nombre", afi.iddistrito);
                ViewBag.tipoEmpresa = new SelectList(afiliadoDL.Listado_tipoEmpresa(), "idtipo", "descripcion", afi.idtipo);
                return View(afi);
            }
            ViewBag.mensaje = afiliadoDL.Registrar_afiliado(afi);
            return RedirectToAction("Listado_afiliado");
        }

        public ActionResult Detalle_afiliado(int id)
        {
            return View(afiliadoDL.Detalle_afiliado(id));
        }

    }
}