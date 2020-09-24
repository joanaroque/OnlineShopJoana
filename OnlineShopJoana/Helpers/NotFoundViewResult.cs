﻿using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace OnlineShopJoana.WEB.Helpers
{
    public class NotFoundViewResult : ViewResult
    {
        public NotFoundViewResult(string viewName)
        {
            ViewName = viewName;
            StatusCode = (int)HttpStatusCode.NotFound;
        }
    }
}
