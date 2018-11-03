using System.Web;
using System.Web.Mvc;

namespace FEUEM_ePresence
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
