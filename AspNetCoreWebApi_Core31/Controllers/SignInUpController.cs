using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreWebApi_Core31.Telemetry;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AspNetCoreWebApi_Core31.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class SignInUpController : ControllerBase
    {

        [HttpPost]
        [TelemetryAttribute(TelemetryAction.SignUp, queryParam: "email")]
        public async Task<IActionResult> SignUp(string email, string firstName, string lastName)
        {
            return Ok();
        }

        //[HttpPost]
        //[TelemetryAttribute(TelemetryAction.SignUp)]
        //public async Task<IActionResult> SignUp([FromBody]SignUpViewModel vm)
        //{
        //    var endpoint = HttpContext.Features.Get<IEndpointFeature>()?.Endpoint;
        //    var attribute = endpoint.Metadata.GetMetadata<TelemetryAttribute>();
        //    attribute.Data = vm.Email;
        //    return Ok();
        //}

        //[HttpPost]
        //[TelemetryAttribute(TelemetryAction.SignIn)]
        //public async Task<IActionResult> SignIn([FromBody]SignInViewModel vm)
        //{
        //    return Ok();

        //}
    }

    public interface IViewModelWithEmail
    {
        string Email { get; set; }
    }

    public class SignInViewModel : IViewModelWithEmail
    {
        public string Email { get; set; }
    }

    public class SignUpViewModel : IViewModelWithEmail
    {
        public string Email { get; set; }
    }
}
