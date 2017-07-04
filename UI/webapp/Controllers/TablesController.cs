#region Using

using RM.Aula.Application.Interfaces;
using RM.Aula.Application.Services;
using System.Web.Mvc;

#endregion

namespace SmartAdminMvc.Controllers
{
    [Authorize]
    public class TablesController : Controller
    {
        private readonly IClienteAppService _clienteAppService;

        public TablesController()
        {
            _clienteAppService = new ClienteAppService();
        }

        // GET: tables/normal
        public ActionResult Normal()
        {
            return View();
        }

        // GET: tables/data-tables
        public ActionResult DataTables()
        {
            return View();
        }

        // GET: tables/jq-grid
        public ActionResult JQGrid()
        {

           // return View(_clienteAppService.ObterAtivos());
           return View();
        }

        public JsonResult GetClientesJQGrid()
        {
            return Json(_clienteAppService.ObterAtivos(), JsonRequestBehavior.AllowGet);
        }
    }
}