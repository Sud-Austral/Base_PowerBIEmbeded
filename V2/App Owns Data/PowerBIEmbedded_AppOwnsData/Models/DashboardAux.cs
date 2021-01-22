using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PowerBIEmbedded_AppOwnsData.Models
{
    public class DashboardAux
    {
        public int id { get; set; }
        public string columna { get; set; }
        public string tabla { get; set; }
        public string reportID { get; set; }
        public string groupID { get; set; }
        public string comentario { get; set; }
        public string nombre { get; set; }

        public DashboardAux(string nombre,int id, string columna, string tabla, string reportID, string groupID, string comentario)
        {
            this.nombre = nombre;
            this.id = id;
            this.columna = columna;
            this.tabla = tabla;
            this.reportID = reportID;
            this.groupID = groupID;
            this.comentario = comentario;
        }

        public DashboardAux()
        {
        }
    }
}