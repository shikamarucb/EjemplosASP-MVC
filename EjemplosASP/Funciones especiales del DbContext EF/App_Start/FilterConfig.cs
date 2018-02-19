using System.Web;
using System.Web.Mvc;

namespace Funciones_especiales_del_DbContext_EF
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
