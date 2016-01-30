﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace ExcellaMobileApp.Helper
{
    public class BindJson : System.Web.Http.Filters.ActionFilterAttribute
    {
        Type _type;
        string _queryStringKey;
        public BindJson(Type type, string queryStringKey)
        {
            _type = type;
            _queryStringKey = queryStringKey;
        }
        public override void OnActionExecuting(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            var json = actionContext.Request.RequestUri.ParseQueryString()[_queryStringKey];
            var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            actionContext.ActionArguments[_queryStringKey] = serializer.Deserialize(json, _type);
        }
    }
}