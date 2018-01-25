using System.Web;
using System.Web.Mvc;

namespace HttpStatusCodeResultEj
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
