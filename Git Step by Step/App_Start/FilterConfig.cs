using System.Web;
using System.Web.Mvc;

namespace Git_Step_by_Step
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}