﻿using Microsoft.AspNetCore.Mvc;

namespace EduCareProject.Controllers
{
    internal class HttpStatusCodeResult : ActionResult
    {
        private object badRequest;

        public HttpStatusCodeResult(object badRequest)
        {
            this.badRequest = badRequest;
        }
    }
}