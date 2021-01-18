using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PowerBIEmbedded_AppOwnsData.Models
{
    public class BaseDashboard
    {
        public List<DashboardAux> dashboards;

        public BaseDashboard()
        {
            dashboards = new List<DashboardAux>();
            //RankingEducaChileRegional
            //dashboards.Add(new DashboardAux(nombre:"RankingEducaChileRegional", id: 1, columna: ""Codreg"", tabla: ""Localiza"", reportID:"3ccff4b0-c9ae-49fb-ae55-35561e96659b", groupID:"4ebe6763-6f4d-4a48-8e0f-f8b3702efea9", comentario: null));
            // RankingEducaChileNacional
            //dashboards.Add(new DashboardAux(nombre:"RankingEducaChileNacional", id:2,columna: null, tabla:null, reportID:"94cd8285-2d9f-4032-a5d8-014aa4d77a5e", groupID:"4ebe6763-6f4d-4a48-8e0f-f8b3702efea9",comentario: null));
            //IPT_Nacional_CL
            dashboards.Add(new DashboardAux(nombre: "IPT_Nacional_CL", id: 1, columna: null, tabla: null, reportID: "a675023e-053c-4b4b-8899-ca544436c79d", groupID: "4ebe6763-6f4d-4a48-8e0f-f8b3702efea9", comentario: "Sin Filtros"));
            //Ranking_Educacion_Nacional_CL
            dashboards.Add(new DashboardAux(nombre: "Ranking_Educacion_Nacional_CL", id: 2, columna: null, tabla: null, reportID: "94cd8285-2d9f-4032-a5d8-014aa4d77a5e", groupID: "4ebe6763-6f4d-4a48-8e0f-f8b3702efea9", comentario: "Sin Filtros"));
            //Ranking_Educacion_Regional_CL
            dashboards.Add(new DashboardAux(nombre: "Ranking_Educacion_Regional_CL", id: 3, columna: "Codreg", tabla: "Localiza", reportID: "3ccff4b0-c9ae-49fb-ae55-35561e96659b", groupID: "4ebe6763-6f4d-4a48-8e0f-f8b3702efea9", comentario: "Filtro Región CL"));
            //Ranking_Educacion_Comunal_CL
            dashboards.Add(new DashboardAux(nombre: "Ranking_Educacion_Comunal_CL", id: 4, columna: "Codcom", tabla: "Localiza", reportID: "c2b71730-c3ce-4291-a21e-31fa45e2ea98", groupID: "4ebe6763-6f4d-4a48-8e0f-f8b3702efea9", comentario: "Filtro Comuna CL"));
            //Evaluación_Servicio_Público_Nacional_CL
            dashboards.Add(new DashboardAux(nombre: "Evaluación_Servicio_Público_Nacional_CL", id: 5, columna: null, tabla: null, reportID: "8a094c2f-d7a9-4472-8a69-f651b5939e85", groupID: "4ebe6763-6f4d-4a48-8e0f-f8b3702efea9", comentario: "Sin Filtros"));
            //INGEI_Nacional_CL
            dashboards.Add(new DashboardAux(nombre: "INGEI_Nacional_CL", id: 6, columna: null, tabla: null, reportID: "f8534f9a-0f6a-4b82-9656-5fb6cd0d8110", groupID: "4ebe6763-6f4d-4a48-8e0f-f8b3702efea9", comentario: "Sin Filtros"));
            //Salud_Papanicolau_Nacional_CL
            dashboards.Add(new DashboardAux(nombre: "Salud_Papanicolau_Nacional_CL", id: 7, columna: null, tabla: null, reportID: "71d10ba1-6a30-4313-a596-24e04d58aeba", groupID: "4ebe6763-6f4d-4a48-8e0f-f8b3702efea9", comentario: "Sin Filtros"));
            //Salud_24_7_Nacional_CL
            dashboards.Add(new DashboardAux(nombre: "Salud_24_7_Nacional_CL", id: 8, columna: null, tabla: null, reportID: "309ccf8e-1f7b-4060-8bb2-0f901f40d5eb", groupID: "4ebe6763-6f4d-4a48-8e0f-f8b3702efea9", comentario: "Sin Filtros"));
            //Comunidad_Linguistica_Nacional_GT
            dashboards.Add(new DashboardAux(nombre: "Comunidad_Linguistica_Nacional_GT", id: 9, columna: null, tabla: null, reportID: "c26cd00a-75ea-47f5-a6d2-d5af308b2cd6", groupID: "2722dcb0-717b-4afe-8a0b-660175a2b8b5", comentario: "Sin Filtros"));
            //Comunidad_Linguistica_Departamento_GT
            dashboards.Add(new DashboardAux(nombre: "Comunidad_Linguistica_Departamento_GT", id: 10, columna: "Id_Dep", tabla: "LOCALIZACION GT", reportID: "f87ec056-929e-4698-937e-0f4c181565c2", groupID: "2722dcb0-717b-4afe-8a0b-660175a2b8b5", comentario: "Filtro Departamento GT"));
            //Registro_Empresas_Nacional_CL
            dashboards.Add(new DashboardAux(nombre: "Registro_Empresas_Nacional_CL", id: 11, columna: null, tabla: null, reportID: "52ad0ee6-7bf1-4842-af35-6949f647ca04", groupID: "4ebe6763-6f4d-4a48-8e0f-f8b3702efea9", comentario: "Sin Filtros"));
            //Muni_Nacional_GT
            dashboards.Add(new DashboardAux(nombre: "Muni_Nacional_GT", id: 12, columna: null, tabla: null, reportID: "d2eb333a-192a-4987-a9a5-ecd7e39d30e4", groupID: "2722dcb0-717b-4afe-8a0b-660175a2b8b5", comentario: "Sin Filtros"));
            //Femicidios_Nacional_CL
            dashboards.Add(new DashboardAux(nombre: "Femicidios_Nacional_CL", id: 13, columna: null, tabla: null, reportID: "b714fba3-f944-47c3-9831-7291e39cd29d", groupID: "4ebe6763-6f4d-4a48-8e0f-f8b3702efea9", comentario: "Sin Filtros"));
            //Avance del COVID-19 - Panamá
            dashboards.Add(new DashboardAux(nombre: "Avance del COVID-19 - Panamá", id: 14, columna: null, tabla: null, reportID: null, groupID: null, comentario: "No Aplica"));
            //Avance del COVID-19 - Honduras
            dashboards.Add(new DashboardAux(nombre: "Avance del COVID-19 - Honduras", id: 15, columna: null, tabla: null, reportID: null, groupID: null, comentario: "No Aplica"));
            //Delitos_Nacional_CL
            dashboards.Add(new DashboardAux(nombre: "Delitos_Nacional_CL", id: 16, columna: null, tabla: null, reportID: "cf28103e-de01-462d-9c38-727cd1e5e3bd", groupID: "4ebe6763-6f4d-4a48-8e0f-f8b3702efea9", comentario: "Sin Filtros"));
            //Avance del COVID-19 - Chile
            dashboards.Add(new DashboardAux(nombre: "Avance del COVID-19 - Chile", id: 17, columna: null, tabla: null, reportID: null, groupID: null, comentario: "No Aplica"));
            //Avance del COVID-19 - Guatemala
            dashboards.Add(new DashboardAux(nombre: "Avance del COVID-19 - Guatemala", id: 18, columna: null, tabla: null, reportID: null, groupID: null, comentario: "No Aplica"));
            //Pueblos_Guatemala_Nacional_GT
            dashboards.Add(new DashboardAux(nombre: "Pueblos_Guatemala_Nacional_GT", id: 19, columna: null, tabla: null, reportID: "87a549ec-c196-4d9e-ad06-020088722884", groupID: "2722dcb0-717b-4afe-8a0b-660175a2b8b5", comentario: "Sin Filtros"));
            //Comunidad_Linguistica_Individual_GT
            dashboards.Add(new DashboardAux(nombre: "Comunidad_Linguistica_Individual_GT", id: 20, columna: "id", tabla: "Comunidades Listado", reportID: "c9204573-dcb0-42d3-999a-d21c398a29b6", groupID: "2722dcb0-717b-4afe-8a0b-660175a2b8b5", comentario: "Filtros por Comunidad Lingüística"));
            //Impactos_ETA_Nacional_HN
            dashboards.Add(new DashboardAux(nombre: "Impactos_ETA_Nacional_HN", id: 21, columna: null, tabla: null, reportID: "b1b03137-10cd-4679-af6f-30bcee85d439", groupID: "4eee1998-74cb-4ddb-885b-3db5a4db255d", comentario: "Sin Filtros - HTML con MapStore"));
            //Incendios_Forestales_Regional_CL
            dashboards.Add(new DashboardAux(nombre: "Incendios_Forestales_Regional_CL", id: 22, columna: "Codreg", tabla: "Localiza", reportID: "511504da-cead-4cdc-b254-795d507a07c9", groupID: "4ebe6763-6f4d-4a48-8e0f-f8b3702efea9", comentario: "Filtro Región CL"));
            //Monitoreo_Fuego_Nacional_HN
            dashboards.Add(new DashboardAux(nombre: "Monitoreo_Fuego_Nacional_HN", id: 23, columna: null, tabla: null, reportID: "ac175849-1273-4a04-a6b9-708afa3508fa", groupID: "4eee1998-74cb-4ddb-885b-3db5a4db255d", comentario: "Sin Filtros - HTML con GEE"));
            //Monitoreo_Fuego_Departamento_HN
            dashboards.Add(new DashboardAux(nombre: "Monitoreo_Fuego_Departamento_HN", id: 24, columna: "Id_Depart", tabla: "Localiza_Honduras", reportID: "d402b070-f109-4f54-b650-5eb84d2b5960", groupID: "4eee1998-74cb-4ddb-885b-3db5a4db255d", comentario: "Filtro Departamento HN  - HTML con GEE"));
            //Monitoreo_Clima_Nacional_HN
            dashboards.Add(new DashboardAux(nombre: "Monitoreo_Clima_Nacional_HN", id: 25, columna: null, tabla: null, reportID: "af9d0d5e-127d-439a-b718-63d1f302cea0", groupID: "4eee1998-74cb-4ddb-885b-3db5a4db255d", comentario: "Sin Filtros - HTML con GEE"));
            //Monitoreo_Clima_Departamento_HN
            dashboards.Add(new DashboardAux(nombre: "Monitoreo_Clima_Departamento_HN", id: 26, columna: "Id_Depart", tabla: "Localiza_HN", reportID: "cab9a957-99a6-4e49-826b-fe3506947703", groupID: "4eee1998-74cb-4ddb-885b-3db5a4db255d", comentario: "Filtro Departamento HN - HTML con GEE"));
            //Monitoreo_Fuego_Nacional_GT
            dashboards.Add(new DashboardAux(nombre: "Monitoreo_Fuego_Nacional_GT", id: 27, columna: null, tabla: null, reportID: "2cf4e74a-5951-4a87-bdab-13636990283d", groupID: "2722dcb0-717b-4afe-8a0b-660175a2b8b5", comentario: "Sin Filtros - HTML con GEE"));
            //Monitoreo_Fuego_Departamento_GT
            dashboards.Add(new DashboardAux(nombre: "Monitoreo_Fuego_Departamento_GT", id: 28, columna: "Id_Depart", tabla: "Localiza_Guatemala", reportID: "4584caf4-55cd-43fd-afb1-c5dc43e20ea6", groupID: "2722dcb0-717b-4afe-8a0b-660175a2b8b5", comentario: "Filtro Departamento GT - HTML con GEE"));
            //Monitoreo_Clima_Nacional_GT
            dashboards.Add(new DashboardAux(nombre: "Monitoreo_Clima_Nacional_GT", id: 29, columna: null, tabla: null, reportID: "43e9321e-9c41-46cd-86f3-2a515d55cb45", groupID: "2722dcb0-717b-4afe-8a0b-660175a2b8b5", comentario: "Sin Filtros - HTML con GEE"));
            //Monitoreo_Clima_Departamento_GT
            dashboards.Add(new DashboardAux(nombre: "Monitoreo_Clima_Departamento_GT", id: 30, columna: "Id_Depart", tabla: "Localiza_GT", reportID: "4df90f94-f72c-470c-a018-aa3731b18c68", groupID: "2722dcb0-717b-4afe-8a0b-660175a2b8b5", comentario: "Filtro Departamento GT - HTML con GEE"));
            //Monitoreo_Fuego_Nacional_PN
            dashboards.Add(new DashboardAux(nombre: "Monitoreo_Fuego_Nacional_PN", id: 31, columna: null, tabla: null, reportID: "6bf63e66-f1e8-4ada-9ab7-dfa7c8d740cd", groupID: "541a5c0a-0f36-4e8e-bb5c-e6a4199e5858", comentario: "Sin Filtros - HTML con GEE"));
            //Monitoreo_Fuego_Departamento_PN
            dashboards.Add(new DashboardAux(nombre: "Monitoreo_Fuego_Departamento_PN", id: 32, columna: "Id_Provi", tabla: "Localiza_Panama", reportID: "b6f89339-0272-465e-8c9e-a232d6b6daf0", groupID: "541a5c0a-0f36-4e8e-bb5c-e6a4199e5858", comentario: "Filtro Departamento PN - HTML con GEE"));
            //Monitoreo_Clima_Nacional_PN
            dashboards.Add(new DashboardAux(nombre: "Monitoreo_Clima_Nacional_PN", id: 33, columna: null, tabla: null, reportID: "61fa143a-3090-4c1b-9932-ab1013e3d4c8", groupID: "541a5c0a-0f36-4e8e-bb5c-e6a4199e5858", comentario: "Sin Filtros - HTML con GEE"));
            //Monitoreo_Clima_Departamento_PN
            dashboards.Add(new DashboardAux(nombre: "Monitoreo_Clima_Departamento_PN", id: 34, columna: "Id_Provi", tabla: "Localiza_PA", reportID: "c17c03ee-312f-414b-953a-09fe6f9dabdf", groupID: "541a5c0a-0f36-4e8e-bb5c-e6a4199e5858", comentario: "Filtro Departamento PN - HTML con GEE"));
            //Monitoreo_Fuego_Nacional_SV
            dashboards.Add(new DashboardAux(nombre: "Monitoreo_Fuego_Nacional_SV", id: 35, columna: null, tabla: null, reportID: "0a5dc135-3853-442f-ab90-970af349f6f8", groupID: "23edd3e0-e067-4e9a-8396-ec4f8ef8bd84", comentario: "Sin Filtros - HTML con GEE"));
            //Monitoreo_Fuego_Departamento_SV
            dashboards.Add(new DashboardAux(nombre: "Monitoreo_Fuego_Departamento_SV", id: 36, columna: "Id_Depart", tabla: "Localiza_El_Salvador", reportID: "dcc21ffe-60ca-484a-87f7-9cc990c07961", groupID: "23edd3e0-e067-4e9a-8396-ec4f8ef8bd84", comentario: "Filtro Departamento SV - HTML con GEE"));
            //Monitoreo_Clima_Nacional_SV
            dashboards.Add(new DashboardAux(nombre: "Monitoreo_Clima_Nacional_SV", id: 37, columna: null, tabla: null, reportID: "d2be08fd-33b8-4495-ac69-8942d8efdd64", groupID: "23edd3e0-e067-4e9a-8396-ec4f8ef8bd84", comentario: "Sin Filtros - HTML con GEE"));
            //Monitoreo_Clima_Departamento_SV
            dashboards.Add(new DashboardAux(nombre: "Monitoreo_Clima_Departamento_SV", id: 38, columna: "Id_Depart", tabla: "Lozaliza_SV", reportID: "ee2989f5-d80d-4fde-8a1b-8fb307b12694", groupID: "23edd3e0-e067-4e9a-8396-ec4f8ef8bd84", comentario: "Filtro Departamento SV"));
            //Monitoreo_Fuego_Nacional_CR
            dashboards.Add(new DashboardAux(nombre: "Monitoreo_Fuego_Nacional_CR", id: 39, columna: null, tabla: null, reportID: "63828826-65ff-41c7-b409-c34cbf5218bb", groupID: "44c9dce5-db80-4443-94f0-572fd312c4cf", comentario: "Sin Filtros - HTML con GEE"));
            //Monitoreo_Fuego_Departamento_CR
            dashboards.Add(new DashboardAux(nombre: "Monitoreo_Fuego_Departamento_CR", id: 40, columna: "Id_Depart", tabla: "Localiza_Costa_Rica", reportID: "857af067-4407-42f3-b900-ae22803b7399", groupID: "44c9dce5-db80-4443-94f0-572fd312c4cf", comentario: "Filtro Departamento CR - HTML con GEE"));
            //Monitoreo_Clima_Nacional_CR
            dashboards.Add(new DashboardAux(nombre: "Monitoreo_Clima_Nacional_CR", id: 41, columna: null, tabla: null, reportID: "6bc13b4b-0032-48bf-879f-2284f36ba88b", groupID: "44c9dce5-db80-4443-94f0-572fd312c4cf", comentario: "Sin Filtros - HTML con GEE"));
            //Monitoreo_Clima_Departamento_CR
            dashboards.Add(new DashboardAux(nombre: "Monitoreo_Clima_Departamento_CR", id: 42, columna: "Id_Depart", tabla: "Localiza_CR", reportID: "02650194-fddc-4069-be3a-3a8652117990", groupID: "44c9dce5-db80-4443-94f0-572fd312c4cf", comentario: "Filtro Departamento CR - HTML con GEE"));
            //Monitoreo_Fuego_Nacional_BZ
            dashboards.Add(new DashboardAux(nombre: "Monitoreo_Fuego_Nacional_BZ", id: 43, columna: null, tabla: null, reportID: "1b75dc13-ced1-4158-9b19-1d6cba060838", groupID: "31dc5c0e-5193-458f-94ba-285436d3f3de", comentario: "Sin Filtros - HTML con GEE"));
            //Monitoreo_Fuego_Departamento_BZ
            dashboards.Add(new DashboardAux(nombre: "Monitoreo_Fuego_Departamento_BZ", id: 44, columna: "Id_dist", tabla: "Localiza_Belice", reportID: "53cdd32e-0eac-4b51-8dce-bded82805b6f", groupID: "31dc5c0e-5193-458f-94ba-285436d3f3de", comentario: "Filtro Departamento BZ - HTML con GEE"));
            //Monitoreo_Clima_Nacional_BZ
            dashboards.Add(new DashboardAux(nombre: "Monitoreo_Clima_Nacional_BZ", id: 45, columna: null, tabla: null, reportID: "a503444a-c7f7-4840-af51-f27ea5d9e652", groupID: "31dc5c0e-5193-458f-94ba-285436d3f3de", comentario: "Sin Filtros - HTML con GEE"));
            //Monitoreo_Clima_Departamento_BZ
            dashboards.Add(new DashboardAux(nombre: "Monitoreo_Clima_Departamento_BZ", id: 46, columna: "Id_dist", tabla: "Localiza_BE", reportID: "54d0a3f9-13df-4f96-ac7a-af10157f24bc", groupID: "31dc5c0e-5193-458f-94ba-285436d3f3de", comentario: "Filtro Departamento BZ - HTML con GEE"));
            //Monitoreo_Fuego_Nacional_RD
            dashboards.Add(new DashboardAux(nombre: "Monitoreo_Fuego_Nacional_RD", id: 47, columna: null, tabla: null, reportID: "15b58ee5-7cf6-4a69-9512-74e552aa5aa3", groupID: "794ba481-34d9-41c2-b759-16d52360f8a3", comentario: "Sin Filtros - HTML con GEE"));
            //Monitoreo_Fuego_Departamento_RD
            dashboards.Add(new DashboardAux(nombre: "Monitoreo_Fuego_Departamento_RD", id: 48, columna: "Id_Provi", tabla: "Localiza_Republica_Dominicana", reportID: "a439495c-5404-4222-a13b-3a555218d38d", groupID: "794ba481-34d9-41c2-b759-16d52360f8a3", comentario: "Filtro Departamento RD - HTML con GEE"));
            //Monitoreo_Clima_Nacional_RD
            dashboards.Add(new DashboardAux(nombre: "Monitoreo_Clima_Nacional_RD", id: 49, columna: null, tabla: null, reportID: "6043c5b8-a614-46cb-99cc-c24f9b7f255f", groupID: "794ba481-34d9-41c2-b759-16d52360f8a3", comentario: "Sin Filtros - HTML con GEE"));
            //Monitoreo_Clima_Departamento_RD
            dashboards.Add(new DashboardAux(nombre: "Monitoreo_Clima_Departamento_RD", id: 50, columna: "Id_Provi", tabla: "Localiza_DO", reportID: "35d65817-ed3d-4033-8b07-4059122246ae", groupID: "794ba481-34d9-41c2-b759-16d52360f8a3", comentario: "Filtro Departamento RD - HTML con GEE"));
            //Monitoreo_Fuego_Nacional_CL
            dashboards.Add(new DashboardAux(nombre: "Monitoreo_Fuego_Nacional_CL", id: 51, columna: null, tabla: null, reportID: "73b6fd7e-9de2-4557-b151-8e1b49bfe03b", groupID: "4ebe6763-6f4d-4a48-8e0f-f8b3702efea9", comentario: "Sin Filtros - HTML con GEE"));
            //Monitoreo_Fuego_Departamento_CL
            dashboards.Add(new DashboardAux(nombre: "Monitoreo_Fuego_Departamento_CL", id: 52, columna: "Id_Region", tabla: "Localiza_Chile", reportID: "9151798a-b539-41bd-a628-8ddf6dc9f3c6", groupID: "4ebe6763-6f4d-4a48-8e0f-f8b3702efea9", comentario: "Filtro Región CL - HTML con GEE"));
            //Monitoreo_Clima_Nacional_CL
            dashboards.Add(new DashboardAux(nombre: "Monitoreo_Clima_Nacional_CL", id: 53, columna: null, tabla: null, reportID: "8a9dc6c6-a9b5-42de-ab0d-e77b9aeb9225", groupID: "4ebe6763-6f4d-4a48-8e0f-f8b3702efea9", comentario: "Sin Filtros - HTML con GEE"));
            //Monitoreo_Clima_Departamento_CL
            dashboards.Add(new DashboardAux(nombre: "Monitoreo_Clima_Departamento_CL", id: 54, columna: "Id_Region", tabla: "Localiza_CL", reportID: "10ca374f-d6d7-49c9-bf4b-56b162b78e1b", groupID: "4ebe6763-6f4d-4a48-8e0f-f8b3702efea9", comentario: "Filtro Región CL - HTML con GEE"));
            //Monitoreo_Fuego_Nacional_NI
            dashboards.Add(new DashboardAux(nombre: "Monitoreo_Fuego_Nacional_NI", id: 55, columna: null, tabla: null, reportID: "8cf4e877-f959-4713-9095-b1100735ebac", groupID: "9c7d801d-7f08-4cfa-af6f-3a09f64af591", comentario: "Sin Filtros - HTML con GEE"));
            //Monitoreo_Fuego_Departamento_NI
            dashboards.Add(new DashboardAux(nombre: "Monitoreo_Fuego_Departamento_NI", id: 56, columna: "Id_Depart", tabla: "Localiza_Nicaragua", reportID: "80e9524e-1124-46e2-9c59-4279cd9ba947", groupID: "9c7d801d-7f08-4cfa-af6f-3a09f64af591", comentario: "Filtro Departamento NI - HTML con GEE"));
            //Monitoreo_Clima_Nacional_NI
            dashboards.Add(new DashboardAux(nombre: "Monitoreo_Clima_Nacional_NI", id: 57, columna: null, tabla: null, reportID: "3f28922e-5296-4ed3-88fe-b2fc54ca50b6", groupID: "9c7d801d-7f08-4cfa-af6f-3a09f64af591", comentario: "Sin Filtros - HTML con GEE"));
            //Monitoreo_Clima_Departamento_NI
            dashboards.Add(new DashboardAux(nombre: "Monitoreo_Clima_Departamento_NI", id: 58, columna: "Id_Depart", tabla: "Localiza_NI", reportID: "68772cf9-5f4c-4aa5-aef0-db4975ba8dfa", groupID: "9c7d801d-7f08-4cfa-af6f-3a09f64af591", comentario: "Filtro Departamento NI - HTML con GEE"));
            //Agrostat_Nacional_CL
            dashboards.Add(new DashboardAux(nombre: "Agrostat_Nacional_CL", id: 59, columna: null, tabla: null, reportID: "692ad8ae-52f4-418d-8eb0-557d3cf37321", groupID: "4ebe6763-6f4d-4a48-8e0f-f8b3702efea9", comentario: "Sin Filtros"));
            //Femicidios_Nacional_HN
            dashboards.Add(new DashboardAux(nombre: "Femicidios_Nacional_HN", id: 60, columna: null, tabla: null, reportID: "f2ca2450-e4c8-4ce5-956a-d265a1caf41f", groupID: "4eee1998-74cb-4ddb-885b-3db5a4db255d", comentario: "Sin Filtros"));
            //Femicidios_Nacional_GT
            dashboards.Add(new DashboardAux(nombre: "Femicidios_Nacional_GT", id: 61, columna: null, tabla: null, reportID: "d819a8e4-1dc0-4006-9a6a-d599b339ba3d", groupID: "2722dcb0-717b-4afe-8a0b-660175a2b8b5", comentario: "Sin Filtros"));
            //Femicidios_Nacional_SV
            dashboards.Add(new DashboardAux(nombre: "Femicidios_Nacional_SV", id: 62, columna: null, tabla: null, reportID: "c5a55169-4c81-49ef-bc78-728129324cc2", groupID: "23edd3e0-e067-4e9a-8396-ec4f8ef8bd84", comentario: "Sin Filtros"));
            //Femicidios_Nacional_PN
            dashboards.Add(new DashboardAux(nombre: "Femicidios_Nacional_PN", id: 63, columna: null, tabla: null, reportID: "e97ff4b4-684f-4a5d-9e56-bb325feaff6f", groupID: "541a5c0a-0f36-4e8e-bb5c-e6a4199e5858", comentario: "Sin Filtros"));
            //Geomática_Agricola_Regional_CL
            dashboards.Add(new DashboardAux(nombre: "Geomática_Agricola_Regional_CL", id: 64, columna: null, tabla: null, reportID: "f0ad5d98-8be7-4598-bef4-b7d93f641f1c", groupID: "4ebe6763-6f4d-4a48-8e0f-f8b3702efea9", comentario: "Sin Filtros en PBI - HTML con GEE y Filtro por Región Chile"));
            //Registro_Empresas_Regional_CL
            dashboards.Add(new DashboardAux(nombre: "Registro_Empresas_Regional_CL", id: 65, columna: "Codreg", tabla: "Localiza", reportID: "0406b2a4-205d-48d1-806e-e67adc81587f", groupID: "4ebe6763-6f4d-4a48-8e0f-f8b3702efea9", comentario: "Filtro Región CL"));

            //PRuebas
            dashboards.Add(new DashboardAux(nombre: "Mapa azure key", id: 9901, columna: "ID_1", tabla: "HND_departamentos1", reportID: "94b4cdc1-5111-4369-b72d-cb812022de24", groupID: "c91b25db-feea-4299-a065-329d736254cb", comentario: "Filtro Departamento NI - HTML con GEE"));






        }
    }
}