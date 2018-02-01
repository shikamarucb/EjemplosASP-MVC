using System.Web;
using System.Web.Mvc;

namespace Introducción_al_Scaffolding
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
