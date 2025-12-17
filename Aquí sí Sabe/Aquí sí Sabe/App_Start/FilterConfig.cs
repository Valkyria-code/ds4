using System.Web;
using System.Web.Mvc;

namespace Aquí_sí_Sabe
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
