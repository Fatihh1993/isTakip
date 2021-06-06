using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kurtProje.ToDo.Web.CustomFilters
{
    public class AdFatihOlamaz : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            


            base.OnActionExecuted(context);
        }
    }
}
