using System.Web;
using System.Web.Mvc;

namespace Display_y_DisplayTemplates
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
