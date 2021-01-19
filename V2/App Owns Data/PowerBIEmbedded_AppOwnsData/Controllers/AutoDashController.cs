using Microsoft.PowerBI.Api.V2.Models;
using PowerBIEmbedded_AppOwnsData.Models;
using PowerBIEmbedded_AppOwnsData.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PowerBIEmbedded_AppOwnsData.Controllers
{
    public class AutoDashController : Controller
    {
        private readonly IEmbedService m_embedService;

        public AutoDashController()
        {
            m_embedService = new EmbedService();
        }

        // GET: AutoDash
        public async Task<ActionResult> Index(int id = 1, int id2 = 1)
        {
            BaseDashboard db = new BaseDashboard();
            DashboardAux d = db.dashboards.Where(x => x.id == id).First();
            ViewBag.codcom = id2;
            ViewBag.columna = d.columna;
            ViewBag.tabla = d.tabla;
            var embedResult = await m_embedService.EmbedReport(null, null, d.reportID, d.groupID);
            if (embedResult)
            {
                return View(m_embedService.EmbedConfig);
            }
            else
            {
                return View(m_embedService.EmbedConfig);
            }
        }

        public ActionResult Hack()
        {
            
            return View();
        }

        public async Task<ActionResult> Index2(int id = 3, int id2 = 3)
        {
            BaseDashboard db = new BaseDashboard();
            DashboardAux d = db.dashboards.Where(x => x.id == id).First();
            ViewBag.codcom = id2;
            ViewBag.columna = d.columna;
            ViewBag.tabla = d.tabla;
            var embedResult = await m_embedService.EmbedReport(null, null, d.reportID, d.groupID);
            if (embedResult)
            {
                return View(m_embedService.EmbedConfig);
            }
            else
            {
                return View(m_embedService.EmbedConfig);
            }
        }


    }
}