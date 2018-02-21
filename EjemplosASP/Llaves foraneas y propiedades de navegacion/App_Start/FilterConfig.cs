using System.Web;
using System.Web.Mvc;

namespace Llaves_foraneas_y_propiedades_de_navegacion
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
