using Login.Controllers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PowerBIEmbedded_AppOwnsData.Controllers
{
    public class LectorExcelController : Controller
    {
        // GET: LectorExcel
        public ActionResult Index()
        {

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            string url = "https://github.com/Sud-Austral/documentos/raw/master/Ian/VINCULOS_PBI.csv";

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            var reader = new StreamReader(resp.GetResponseStream());
            List<Lectura> salida = new List<Lectura>();
            while (!reader.EndOfStream)
            {
                //salida = salida + reader.ReadLine();
                var line = reader.ReadLine();
                var values = line.Split(',');
                salida.Add(new Lectura(values[0], values[1], values[2], values[3], values[4]));
                //this.ordenes.Add(new Orden(values[9], values[23], values[18]));
                //this.ordenes.Add(new Orden(values[],values[],values[],values[],values[]));
                //string values_r = values[1].Replace("\"", "");
            }
            salida.RemoveAt(0);
            ViewBag.resultado = salida;
            return View();
        }
        /*
        public int ParseNumero(string id="1")
        {
            string input = id;
            try
            {
                int result = Int32.Parse(input);
                return result;
            }
            catch (FormatException)
            {
                return 2;
            }
            //return 1;
        }
        */
        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
