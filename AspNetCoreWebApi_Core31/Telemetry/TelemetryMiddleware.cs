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
    //public class TelemetryMiddleware
    //{
    //    private RequestDelegate _next;

    //    public TelemetryMiddleware(RequestDelegate next)
    //    {
    //        _next = next;
    //    }

    //    public async Task Invoke(HttpContext context)
    //    {
    //        //This is important to call BEFORE invoking action to be able to read the body again afterwards
    //        context.Request.EnableBuffering(); // Use .EnableRewind() for .NET Core 2.x

    //        await _next(context); // The action in the controller will be called here
    //        try // Use try/catch here because you don't want the middleware to interfere with normal functionality
    //        {
    //            var endpoint = context.Features.Get<IEndpointFeature>()?.Endpoint;
    //            var attribute = endpoint?.Metadata.GetMetadata<TelemetryAttribute>();
    //            if (attribute != null)
    //            {
    //                var action = attribute.Action;

    //                if (action == TelemetryAction.SignUp)
    //                {
    //                    var bodyStr = await GetRequestBody(context);
    //                    var vm = JsonConvert.DeserializeObject<SignUpViewModel>(bodyStr);
    //                    var email = vm.Email;
    //                }
    //            }
    //        }
    //        catch { }
    //    }

    //    private static async Task<string> GetRequestBody(HttpContext context)
    //    {
    //        var bodyStr = "";
    //        var req = context.Request;
    //        req.Body.Position = 0;
    //        using (StreamReader reader
    //            = new StreamReader(req.Body, Encoding.UTF8, detectEncodingFromByteOrderMarks: true, leaveOpen: true))
    //        {
    //            bodyStr = await reader.ReadToEndAsync();
    //        }
    //        return bodyStr;
    //    }
    //}
}