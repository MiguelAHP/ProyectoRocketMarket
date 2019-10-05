using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using APP_MARKEPLACE.Entity;
using APP_MARKEPLACE.Models;
using APP_MARKEPLACE.SQLServer;

namespace APP_MARKEPLACE.Controllers
{
    public class AccesoController : Controller
    {
        UsuarioDL usuarioDL = new UsuarioDL();
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Listado_usuario()
        {
            return View(usuarioDL.Listado_usuario());
        }

        public ActionResult Registrar_usuario()
        {
            ViewBag.pais = new SelectList(usuarioDL.Listado_pais(), "idpais", "descripcion");
            ViewBag.sexo = new SelectList(usuarioDL.Listado_sexo(), "idsexo", "descripcion");
            return View(new Usuario());
        }

        [HttpPost]
        public ActionResult Registrar_usuario(Usuario us)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.pais = new SelectList(usuarioDL.Listado_pais(), "idpais", "descripcion", us.idpais);
                ViewBag.sexo = new SelectList(usuarioDL.Listado_sexo(), "idsexo", "descripcion", us.idsexo);
                return View(us);
            }
            ViewBag.mensaje = usuarioDL.Registrar_usuario(us);
            return RedirectToAction("Listado_usuario", "Acceso");
        }
    }
}