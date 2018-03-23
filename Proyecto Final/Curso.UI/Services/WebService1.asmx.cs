using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Web.Services;

namespace Curso.UI.Services
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string GetData()
        {
            List<Persona> oList = new List<Persona>();
            for (int i = 0; i < 10; i++)
            {
                oList.Add(new Persona("Fernando-" + i.ToString(), "Rodriguez-" + i.ToString(), "4-698-777" + i.ToString()));
            }
            return new JavaScriptSerializer().Serialize(oList);
        }
    }
}
