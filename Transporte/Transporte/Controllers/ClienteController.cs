using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Transporte.Repositories.EntityFramework.TransporteDB;
using Transporte.Repositories.EntityFramework;
using Transporte.Models;

namespace Transporte.Controllers
{
    public class ClienteController : Controller
    {
        private readonly TransporteUnitOfWork _context;

        // GET: Cliente
        public ActionResult ClienteIndex()
        {
            using (var unit = new TransporteUnitOfWork(new TransporteDBContext()))
            {
                return View(unit.Clientes.GetList().ToList());
            }    
        }

        public ActionResult ClienteCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ClienteCreate(Cliente clientes)
        {
            if (ModelState.IsValid)
            {
                using (var unit = new TransporteUnitOfWork(new TransporteDBContext()))
                {
                    unit.Clientes.Insert(clientes);
                    unit.Complete();
                }

                return RedirectToAction("ClienteIndex");
            }

            return View();
        }

        public ActionResult ClienteUpdate(int id)
        {
            using (var unit = new TransporteUnitOfWork(new TransporteDBContext()))
            {
 
                return View(unit.Clientes.GetById(id));
            }
            
        }

        [HttpPost]
        public ActionResult ClienteUpdate(Cliente clientes)
        {

            using (var unit = new TransporteUnitOfWork(new TransporteDBContext()))
            {

                unit.Clientes.Update(clientes);
                unit.Complete();

                return RedirectToAction("ClienteIndex");
            }
   
        }

        public ActionResult ClienteDelete(int id)
        {
            using (var unit = new TransporteUnitOfWork(new TransporteDBContext()))
            {

                return View(unit.Clientes.GetById(id));
            }
        }

        [HttpPost]
        //[ActionName("Delete")] esto es para que me reconozca a traves de la vista ya que la vista llama el post
        public ActionResult ClienteDelete(Cliente clientes)
        {
            using (var unit = new TransporteUnitOfWork(new TransporteDBContext()))
            {
                var nuevoCliente = unit.Clientes.GetById(clientes.IdCliente);
                unit.Clientes.Delete(nuevoCliente);
                unit.Complete();

                return RedirectToAction("ClienteIndex");
            }
        }
    }
}