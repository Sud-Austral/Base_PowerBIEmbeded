using PowerBIEmbedded_AppOwnsData.Models;
using PowerBIEmbedded_AppOwnsData.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PowerBIEmbedded_AppOwnsData.Controllers
{
    public class TestController : Controller
    {
        private readonly IEmbedService m_embedService;

        public TestController()
        {
            m_embedService = new EmbedService();
        }
        // GET: Test
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

        public async Task<ActionResult> EmbedReport(int id)
        {

            ViewBag.codcom = id;
            ViewBag.columna = "Codcom";
            ViewBag.tabla = "Medio_Ambiente";
            var embedResult = await m_embedService.EmbedReport(null, null, "264e7426-a930-49cf-a552-a0ab387df342");
            //var embedResult = await m_embedService.EmbedReport(null, null, "f9eafdc6-98a1-4aa9-a525-66b9a2136e0d");
            //var embedResult = await m_embedService.EmbedReport(null, null, "5c435e01-ed69-4d55-a996-6dc6871b4174");
            if (embedResult)
            {
                //m_embedService.EmbedConfig.EmbedUrl = "https://app.powerbi.com/reportEmbed?reportId=8f96cbcd-dcd2-4cc6-9cf5-b4897758069f&autoAuth=true&ctid=8fbaa5bf-2ecc-4dc8-b56b-8f92e307f076&config=eyJjbHVzdGVyVXJsIjoiaHR0cHM6Ly93YWJpLXNvdXRoLWNlbnRyYWwtdXMtcmVkaXJlY3QuYW5hbHlzaXMud2luZG93cy5uZXQvIn0%3D";
                return View(m_embedService.EmbedConfig);
            }
            else
            {
                return View(m_embedService.EmbedConfig);
            }
        }

        public string dos(string id, string id2)
        //public string dos(string id)
        {
            //return id;

            return id + id2;
        }
    }
}