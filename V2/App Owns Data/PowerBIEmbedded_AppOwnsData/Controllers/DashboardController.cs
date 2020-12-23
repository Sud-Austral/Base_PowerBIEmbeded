using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Microsoft.PowerBI.Api.V2;
using Microsoft.PowerBI.Api.V2.Models;
using Microsoft.Rest;
using PowerBIEmbedded_AppOwnsData.Models;
using PowerBIEmbedded_AppOwnsData.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PowerBIEmbedded_AppOwnsData.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IEmbedService m_embedService;

        public DashboardController()
        {
            m_embedService = new EmbedService();
        }

        // GET: Dashboard
        public ActionResult Index()
        {
            return View();
        }
        
        public async Task<ActionResult> PruebaMapa(string id, string id2)
        {
            var embedResult = await m_embedService.EmbedReport(null, null, id, id2);
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