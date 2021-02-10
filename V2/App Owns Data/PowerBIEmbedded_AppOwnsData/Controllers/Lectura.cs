using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace Login.Controllers
{
    public class Lectura
    {
        //nombre id id2 url comentario
        public string nombre { get; set; }
        public string id { get; set; }
        public string id2 { get; set; }
        public string url { get; set; }
        public string comentario { get; set; }


        public Lectura(string nombre, string id, string id2, string url, string comentario)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            this.nombre = nombre;
            this.id = id;
            this.id2 = id2;
            this.url = url;
            this.comentario = comentario;
        }
    }
}