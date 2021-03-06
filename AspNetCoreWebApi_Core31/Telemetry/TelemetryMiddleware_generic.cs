﻿using AspNetCoreWebApi_Core31.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AspNetCoreWebApi_Core31.Telemetry
{
    public class TelemetryMiddleware
    {
        private RequestDelegate _next;

        public TelemetryMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            await _next(context); // The action in the controller will be called here

            var endpoint = context.Features.Get<IEndpointFeature>()?.Endpoint;
            var attribute = endpoint?.Metadata.GetMetadata<TelemetryAttribute>();
            if (attribute != null)
            {
                var data = context.Request.Query[attribute.QueryParam];
                // add telemetry or logging here
            }
        }

        private static async Task<string> GetRequestBody(HttpContext context)
        {
            var req = context.Request;
            req.Body.Position = 0;
            using (StreamReader reader
                = new StreamReader(req.Body, Encoding.UTF8, detectEncodingFromByteOrderMarks: true, leaveOpen: true))
            {
                return await reader.ReadToEndAsync();
            }
        }
    }
}
