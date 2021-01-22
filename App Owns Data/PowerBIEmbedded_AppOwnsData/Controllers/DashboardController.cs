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

        //Chile
        public async Task<ActionResult> MapaPrueba(string id = "Colón")
        {
            ViewBag.codcom = id;
            ViewBag.columna = "Chile Comuna";
            ViewBag.tabla = "DATACOVID CL";
            //var embedResult = await m_embedService.EmbedReport(null, null, "77f365eb-0cbf-4c0b-8bf9-66d87b47ab60", "f9eafdc6-98a1-4aa9-a525-66b9a2136e0d");
            var embedResult = await m_embedService.EmbedReport(null, null, "49fec21e-5ac3-4b64-b235-94dcc17f033b", "60cc62aa-77d2-4b77-b178-beee536e2be1");
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
            ViewBag.columna = "COVIDCHILE Mapas";
            ViewBag.tabla = "DATACOVID CL";
            //var embedResult = await m_embedService.EmbedReport(null, null, "77f365eb-0cbf-4c0b-8bf9-66d87b47ab60", "f9eafdc6-98a1-4aa9-a525-66b9a2136e0d");
            var embedResult = await m_embedService.EmbedReport(null, null, "a66475b3-a0c3-42e7-9e37-1c939e0a9df9", "60cc62aa-77d2-4b77-b178-beee536e2be1");
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
            ViewBag.columna = "Evolucion";
            ViewBag.tabla = "DATACOVID CL";
            //var embedResult = await m_embedService.EmbedReport(null, null, "77f365eb-0cbf-4c0b-8bf9-66d87b47ab60", "f9eafdc6-98a1-4aa9-a525-66b9a2136e0d");
            var embedResult = await m_embedService.EmbedReport(null, null, "97b24c41-9be2-44d8-9e84-364248a592b4", "60cc62aa-77d2-4b77-b178-beee536e2be1");
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
            ViewBag.columna = "Nuevos objetos visuales";
            ViewBag.tabla = "DATACOVID CL";
            //var embedResult = await m_embedService.EmbedReport(null, null, "77f365eb-0cbf-4c0b-8bf9-66d87b47ab60", "f9eafdc6-98a1-4aa9-a525-66b9a2136e0d");
            var embedResult = await m_embedService.EmbedReport(null, null, "db783cab-ee87-40f9-86ee-5f3d4d834f09", "60cc62aa-77d2-4b77-b178-beee536e2be1");
            if (embedResult)
            {
                return View(m_embedService.EmbedConfig);
            }
            else
            {
                return View(m_embedService.EmbedConfig);
            }
        }


        //Guatemala
        public async Task<ActionResult> MapaPrueba(string id = "Colón")
        {
            ViewBag.codcom = id;
            ViewBag.columna = "Alimentación GT";
            ViewBag.tabla = "DATACOVID GT";
            var embedResult = await m_embedService.EmbedReport(null, null, "ff63f348-7140-4465-8789-ddac42a41cf3", "fae8ec2b-b673-42ae-a9f7-8c00095bb523");
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
            ViewBag.columna = "Economía GT";
            ViewBag.tabla = "DATACOVID GT";
            var embedResult = await m_embedService.EmbedReport(null, null, "aaf020d7-4ece-4bed-939b-a2ddd6444fa1", "fae8ec2b-b673-42ae-a9f7-8c00095bb523");
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
            ViewBag.columna = "Farmacias GT";
            ViewBag.tabla = "DATACOVID GT";
            var embedResult = await m_embedService.EmbedReport(null, null, "3cfdd557-e39d-4ee5-b134-6dbfab073ec5", "fae8ec2b-b673-42ae-a9f7-8c00095bb523");
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
            ViewBag.columna = "Hospitales GT";
            ViewBag.tabla = "DATACOVID GT";
            var embedResult = await m_embedService.EmbedReport(null, null, "b9c35652-14c6-4b5e-8246-dba32a5426a4", "fae8ec2b-b673-42ae-a9f7-8c00095bb523");
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
            ViewBag.columna = "Nacional GT";
            ViewBag.tabla = "DATACOVID GT";
            var embedResult = await m_embedService.EmbedReport(null, null, "ba2105aa-7372-4c30-93ce-9c4a3602d955", "fae8ec2b-b673-42ae-a9f7-8c00095bb523");
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
            ViewBag.columna = "Restricciones Sanitarias GT";
            ViewBag.tabla = "DATACOVID GT";
            var embedResult = await m_embedService.EmbedReport(null, null, "c764cbf3-7a27-48b9-b25a-026802f110e2", "fae8ec2b-b673-42ae-a9f7-8c00095bb523");
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
            ViewBag.columna = "RRSS GT";
            ViewBag.tabla = "DATACOVID GT";
            var embedResult = await m_embedService.EmbedReport(null, null, "6c3e3988-ebbc-468b-9b6b-03d91226c27e", "fae8ec2b-b673-42ae-a9f7-8c00095bb523");
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
            ViewBag.columna = "Trabajo GT";
            ViewBag.tabla = "DATACOVID GT";
            var embedResult = await m_embedService.EmbedReport(null, null, "2357c84f-464a-4f9f-bed6-039f4ce61a5b", "fae8ec2b-b673-42ae-a9f7-8c00095bb523");
            if (embedResult)
            {
                return View(m_embedService.EmbedConfig);
            }
            else
            {
                return View(m_embedService.EmbedConfig);
            }
        }

        //Honduras
        public async Task<ActionResult> MapaPrueba(string id = "Colón")
        {
            ViewBag.codcom = id;
            ViewBag.columna = "Alimentación HN";
            ViewBag.tabla = "DATACOVID HN";
            var embedResult = await m_embedService.EmbedReport(null, null, "da1e379f-ed82-4a5d-82c4-949d9915971e", "9a7cb730-9aea-486b-95b1-80864318d88f");
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
            ViewBag.columna = "Economía HN";
            ViewBag.tabla = "DATACOVID HN";
            var embedResult = await m_embedService.EmbedReport(null, null, "5c4f7f65-3dcc-48bb-91f7-d170748f7175", "9a7cb730-9aea-486b-95b1-80864318d88f");
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
            ViewBag.columna = "Farmacias HN";
            ViewBag.tabla = "DATACOVID HN";
            var embedResult = await m_embedService.EmbedReport(null, null, "0dd8468e-2cd7-4ec1-b897-eabb89860004", "9a7cb730-9aea-486b-95b1-80864318d88f");
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
            ViewBag.columna = "Hospitales HN";
            ViewBag.tabla = "DATACOVID HN";
            var embedResult = await m_embedService.EmbedReport(null, null, "afdacdfe-9f34-428a-83b7-932bfa1a13da", "9a7cb730-9aea-486b-95b1-80864318d88f");
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
            ViewBag.columna = "Nacional HN";
            ViewBag.tabla = "DATACOVID HN";
            var embedResult = await m_embedService.EmbedReport(null, null, "2a9dd83e-a3e7-40ad-9112-4cc501e5f685", "9a7cb730-9aea-486b-95b1-80864318d88f");
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
            ViewBag.columna = "Restricciones Sanitarias HN";
            ViewBag.tabla = "DATACOVID HN";
            var embedResult = await m_embedService.EmbedReport(null, null, "995ae9ae-4b82-4c30-9fe4-c41526bbf3f2", "9a7cb730-9aea-486b-95b1-80864318d88f");
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
            ViewBag.columna = "RRSS HN";
            ViewBag.tabla = "DATACOVID HN";
            var embedResult = await m_embedService.EmbedReport(null, null, "8cedca44-1e8e-46ec-a468-b3d507d4bc51", "9a7cb730-9aea-486b-95b1-80864318d88f");
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
            ViewBag.columna = "Trabajo HN";
            ViewBag.tabla = "DATACOVID HN";
            var embedResult = await m_embedService.EmbedReport(null, null, "a9ff4d4b-9281-455d-a38a-5eaf65031045", "9a7cb730-9aea-486b-95b1-80864318d88f");
            if (embedResult)
            {
                return View(m_embedService.EmbedConfig);
            }
            else
            {
                return View(m_embedService.EmbedConfig);
            }
        }

        //Panamá
        public async Task<ActionResult> MapaPrueba(string id = "Colón")
        {
            ViewBag.codcom = id;
            ViewBag.columna = "Alimentación PN";
            ViewBag.tabla = "DATACOVID PN";
            var embedResult = await m_embedService.EmbedReport(null, null, "3081a777-7a25-48c2-9488-fc2c53349b0d", "2fc8bf1f-a260-45b6-9cbc-2facdd1f742b");
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
            ViewBag.columna = "Comparativo PN";
            ViewBag.tabla = "DATACOVID PN";
            var embedResult = await m_embedService.EmbedReport(null, null, "5aaf0d56-4e05-4fa4-9279-b4c74596a9e4", "2fc8bf1f-a260-45b6-9cbc-2facdd1f742b");
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
            ViewBag.columna = "Economía PN";
            ViewBag.tabla = "DATACOVID PN";
            var embedResult = await m_embedService.EmbedReport(null, null, "f7c4ba2c-3b36-49cc-a59b-24dc1220976e", "2fc8bf1f-a260-45b6-9cbc-2facdd1f742b");
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
            ViewBag.columna = "Farmacias PN";
            ViewBag.tabla = "DATACOVID PN";
            var embedResult = await m_embedService.EmbedReport(null, null, "8fdc9e5b-4303-40f7-8c05-d9857ac7636b", "2fc8bf1f-a260-45b6-9cbc-2facdd1f742b");
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
            ViewBag.columna = "Hospitales PN";
            ViewBag.tabla = "DATACOVID PN";
            var embedResult = await m_embedService.EmbedReport(null, null, "9b09b7b1-2b57-4f7c-8430-2e0ca5810243", "2fc8bf1f-a260-45b6-9cbc-2facdd1f742b");
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
            ViewBag.columna = "Nacional PN1";
            ViewBag.tabla = "DATACOVID PN";
            var embedResult = await m_embedService.EmbedReport(null, null, "58c06a6b-1db2-4078-b143-15cf90882b2d", "2fc8bf1f-a260-45b6-9cbc-2facdd1f742b");
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
            ViewBag.columna = "Restricciones Sanitarias PN";
            ViewBag.tabla = "DATACOVID PN";
            var embedResult = await m_embedService.EmbedReport(null, null, "b281c397-1d54-4e1e-9c0f-5bbc14f43220", "2fc8bf1f-a260-45b6-9cbc-2facdd1f742b");
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
            ViewBag.columna = "RRSS PN";
            ViewBag.tabla = "DATACOVID PN";
            var embedResult = await m_embedService.EmbedReport(null, null, "cae66458-ab85-4d0d-8c4e-37eefaddaf2}¿'", "2fc8bf1f-a260-45b6-9cbc-2facdd1f742b");
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
            ViewBag.columna = "Trabajo PN";
            ViewBag.tabla = "DATACOVID PN";
            var embedResult = await m_embedService.EmbedReport(null, null, "a267586b-4028-4ea0-8ed4-2e7cfe818a4b", "2fc8bf1f-a260-45b6-9cbc-2facdd1f742b");
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