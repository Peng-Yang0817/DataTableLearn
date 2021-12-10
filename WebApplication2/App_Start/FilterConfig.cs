using System.Web;
using System.Web.Mvc;
using MvcApp.Filter;

namespace WebApplication2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //授權過濾器
            filters.Add(new MyAuthorizeAttribute());
            //異常處理過濾器
            filters.Add(new MyHandleErrorAttribute());
        }
    }
}
