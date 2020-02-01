using System.Web;
using System.Web.Mvc;

namespace MiBotica.SolPedidos.Cliente.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
