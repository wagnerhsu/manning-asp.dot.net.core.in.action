﻿using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using NLog;

namespace ResourceFilterDemo01.Infrastructure
{
    public class LogResourceFilter : Attribute, IResourceFilter
    {
        ILogger _logger = LogManager.GetCurrentClassLogger();
        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            _logger.Debug("Executing IResourceFilter.OnResourceExecuting");
            //context.Result = new ContentResult()
            //{
            //    Content = "IResourceFilter - Short-circuiting ",
            //};
        }

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            _logger.Debug($"Executing IResourceFilter.OnResourceExecuted: cancelled {context.Canceled}");
        }
    }
}
