﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Easy.Web.Attribute
{
    public abstract class ViewDataAttribute : FilterAttribute, IActionFilter
    {
        public abstract void OnActionExecuted(ActionExecutedContext filterContext);

        public abstract void OnActionExecuting(ActionExecutingContext filterContext);

    }
}
