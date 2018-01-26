using System.Web;
using System.Web.Mvc;

namespace RenderAction_y_Action
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
