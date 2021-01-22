using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PowerBIEmbedded_AppOwnsData.Models
{
    public class PowerBiDash
    {
        public int id { get; set; }
        public int id2 { get; set; }
        public string url { get; set; }
        public string comentario { get; set; }
        public string titulo { get; set; }

        public PowerBiDash(string titulo, int id, int id2, string url, string comentario)
        {
            this.titulo = titulo;
            this.id = id;
            this.id2 = id2;
            this.url = url;
            this.comentario = comentario;
        }
    }
}