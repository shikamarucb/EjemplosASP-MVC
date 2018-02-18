using System.Web;
using System.Web.Mvc;

namespace Passwords_y_TextArea_Scaffolding_DataType
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
