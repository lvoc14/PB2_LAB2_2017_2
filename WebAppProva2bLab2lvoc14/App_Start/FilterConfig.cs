using System.Web;
using System.Web.Mvc;

namespace WebAppProva2bLab2lvoc14
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
