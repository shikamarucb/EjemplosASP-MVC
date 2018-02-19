using System.Web;
using System.Web.Mvc;

namespace Insertando_registros_con_Entity_Framework
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
