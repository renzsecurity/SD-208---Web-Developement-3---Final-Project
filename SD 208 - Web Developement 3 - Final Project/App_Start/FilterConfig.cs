using System.Web;
using System.Web.Mvc;

namespace SD_208___Web_Developement_3___Final_Project
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
