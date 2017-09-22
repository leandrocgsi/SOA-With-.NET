using System.Web;
using System.Web.Mvc;

namespace SOA_Project.Presentation.ASPNETMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
