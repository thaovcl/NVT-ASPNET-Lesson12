using System.Web;
using System.Web.Mvc;

namespace NVTLesson12_ontap
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
