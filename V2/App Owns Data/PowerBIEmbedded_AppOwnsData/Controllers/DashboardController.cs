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

        public async Task<ActionResult> PruebaMapa2(string id = "Colón")
        {
            ViewBag.codcom = id;
            ViewBag.columna = "Departamento";
            ViewBag.tabla = "Localiza_HN";
            var embedResult = await m_embedService.EmbedReport(null, null, "90461ecc-1682-492c-af3f-41b2063619b9", "f9eafdc6-98a1-4aa9-a525-66b9a2136e0d");
            if (embedResult)
            {
                return View(m_embedService.EmbedConfig);
            }
            else
            {
                return View(m_embedService.EmbedConfig);
            }
        }

        public async Task<ActionResult> PruebaMapaNacional()
        {
            //ViewBag.codcom = id;
            //ViewBag.columna = "Departamento";
            //ViewBag.tabla = "Localiza_HN";
            var embedResult = await m_embedService.EmbedReport(null, null, "90461ecc-1682-492c-af3f-41b2063619b9", "f9eafdc6-98a1-4aa9-a525-66b9a2136e0d");
            if (embedResult)
            {
                return View(m_embedService.EmbedConfig);
            }
            else
            {
                return View(m_embedService.EmbedConfig);
            }
        }

        public async Task<ActionResult> Pruebalenguistica(int id = 1)
        { 
            ViewBag.codcom = id;
            ViewBag.columna = "Id_Dep";
            ViewBag.tabla = "LOCALIZACION GT";
            if(id == 0)
            {
                ViewBag.codcom = null;
                ViewBag.columna = null;
                ViewBag.tabla = null;
            }
            var embedResult = await m_embedService.EmbedReport(null, null, "fc8662a7-e884-4f56-a270-4c4ecb8d8136", "f9eafdc6-98a1-4aa9-a525-66b9a2136e0d");
            if (id == 0)
            {
                embedResult = await m_embedService.EmbedReport(null, null, "d0402a92-a413-4cb5-9c28-10bd031b2a81", "f9eafdc6-98a1-4aa9-a525-66b9a2136e0d");
            }
            if (embedResult)
            {
                return View(m_embedService.EmbedConfig);
            }
            else
            {
                return View(m_embedService.EmbedConfig);
            }
        }

        public async Task<ActionResult> PruebaHonduras(string id = "Colón")
        {
            
            ViewBag.codcom = id;
            ViewBag.columna = "Departamento";
            ViewBag.tabla = "Localiza_HN";
            var embedResult = await m_embedService.EmbedReport(null, null, "cab9a957-99a6-4e49-826b-fe3506947703", "4eee1998-74cb-4ddb-885b-3db5a4db255d");
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