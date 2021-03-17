using System.Web;
using System.Web.Mvc;

namespace _5951071124_NguyenHoangVuong
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
