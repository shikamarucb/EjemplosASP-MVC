using System.Web;
using System.Web.Mvc;

namespace Ocultando_campos_con_ScaffoldColumn
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
