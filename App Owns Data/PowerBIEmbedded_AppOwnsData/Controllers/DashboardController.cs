using PowerBIEmbedded_AppOwnsData.Models;
using PowerBIEmbedded_AppOwnsData.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
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

        public ActionResult Index()
        {
            var result = new IndexConfig();
            var assembly = Assembly.GetExecutingAssembly().GetReferencedAssemblies().Where(n => n.Name.Equals("Microsoft.PowerBI.Api")).FirstOrDefault();
            if (assembly != null)
            {
                result.DotNETSDK = assembly.Version.ToString(3);
            }
            return View(result);
        }

        public async Task<ActionResult> EmbedReport(string id = "Colón")
        {
            //byte[] bytes = Encoding.Default.GetBytes(id);
            //id = Encoding.UTF8.GetString(bytes);
            ViewBag.codcom = id;

            ViewBag.columna = "Departamento";
            ViewBag.tabla = "Localiza_HN";
            //var embedResult = await m_embedService.EmbedReport(null, null, "77f365eb-0cbf-4c0b-8bf9-66d87b47ab60", "f9eafdc6-98a1-4aa9-a525-66b9a2136e0d");
            var embedResult = await m_embedService.EmbedReport(null, null, "90461ecc-1682-492c-af3f-41b2063619b9", "f9eafdc6-98a1-4aa9-a525-66b9a2136e0d");
            //var embedResult = await m_embedService.EmbedReport(null, null, "f9eafdc6-98a1-4aa9-a525-66b9a2136e0d");
            //var embedResult = await m_embedService.EmbedReport(null, null, "5c435e01-ed69-4d55-a996-6dc6871b4174");
            if (embedResult)
            {
                return View(m_embedService.EmbedConfig);
            }
            else
            {
                return View(m_embedService.EmbedConfig);
            }
        }

        public async Task<ActionResult> MapaPrueba(string id = "Colón")
        {
            ViewBag.codcom = id;
            ViewBag.columna = "Departamento";
            ViewBag.tabla = "Localiza_HN";
            //var embedResult = await m_embedService.EmbedReport(null, null, "77f365eb-0cbf-4c0b-8bf9-66d87b47ab60", "f9eafdc6-98a1-4aa9-a525-66b9a2136e0d");
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

        public async Task<ActionResult> MapaPrueba2()
        {
            //var embedResult = await m_embedService.EmbedReport(null, null, "77f365eb-0cbf-4c0b-8bf9-66d87b47ab60", "f9eafdc6-98a1-4aa9-a525-66b9a2136e0d");
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
    }
}