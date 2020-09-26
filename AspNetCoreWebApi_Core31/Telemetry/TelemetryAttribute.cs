using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreWebApi_Core31.Telemetry
{
    public class TelemetryAttribute : Attribute
    {
        public TelemetryAction Action { get; set; }
        //public string Data { get; set; }
        public string QueryParam { get; set; }

        public TelemetryAttribute(TelemetryAction action, string queryParam)
        {
            Action = action;
            QueryParam = queryParam;
        }
    }

    public enum TelemetryAction { SignUp, SignIn }
}
