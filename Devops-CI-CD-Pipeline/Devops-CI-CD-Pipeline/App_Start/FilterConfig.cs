using System.Web;
using System.Web.Mvc;

namespace Devops_CI_CD_Pipeline
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
