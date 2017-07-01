using RM.Aula.Application.Interfaces;
using RM.Aula.Application.Services;
using RM.Aula.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Web.Mvc;
namespace SmartAdminMvc.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClienteAppService _clienteAppService;
        private readonly IPaisAppService _paisAppService;
        private readonly IEstadoAppService _estadoAppService;
        private readonly ICidadeAppService _cidadeAppService;
        public ClientesController()
        {
            _clienteAppService = new ClienteAppService();
            _paisAppService = new PaisAppService();
            _estadoAppService = new EstadoAppService();
            _cidadeAppService = new CidadeAppService();
        }
        public ActionResult Index()
        {
            return View(_clienteAppService.ObterAtivos());
        }
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var clienteViewModel = _clienteAppService.ObterPorId(id.Value);
            if (clienteViewModel == null)
            {
                return HttpNotFound();
            }
            return View(clienteViewModel);
        }
        public ActionResult Create()
        {
            ViewBag.ListaPaises = new SelectList(_paisAppService.ObteTodos(), "Id", "Descricao");            
            return View();
        }

        
        public JsonResult getstate(Guid id)
        {
            return Json(new SelectList(_estadoAppService.ObterEstado(id), "Id", "Descricao", JsonRequestBehavior.AllowGet));
        }

        
        public JsonResult getcity(Guid id)
        {
            return Json(new SelectList(_cidadeAppService.ObterCidade(id), "Id", "Descricao", JsonRequestBehavior.AllowGet));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteEnderecoViewModel clienteenderecoViewModel)
        {
            if (ModelState.IsValid)
            {
                _clienteAppService.Adicionar(clienteenderecoViewModel);
                return RedirectToAction("Index");
            }
            return View(clienteenderecoViewModel);
        }
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var clienteViewModel = _clienteAppService.ObterPorId(id.Value);
            if (clienteViewModel == null)
            {
                return HttpNotFound();
            }
            return View(clienteViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClienteViewModel clienteViewModel)
        {
            if (ModelState.IsValid)
            {
                _clienteAppService.Atualizar(clienteViewModel);
                return RedirectToAction("Index");
            }
            return View(clienteViewModel);
        }
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var clienteViewModel = _clienteAppService.ObterPorId(id.Value);
            if (clienteViewModel == null)
            {
                return HttpNotFound();
            }
            return View(clienteViewModel);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _clienteAppService.Remover(id);
            return RedirectToAction("Index");
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _clienteAppService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
