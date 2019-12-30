using AspNetCoreMVC_Core31.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVC_Core31.Controllers
{
    //[Route("api/[controller]/[action]")]
    public class CalculatorController : Controller
    {
        [HttpGet]
        public int Divide(int a, int b)
        {
            var result = DivideInternal(a, b);
            return result;
        }

        private int DivideInternal(int a, int b)
        {
            return a / b;
        }
    }
}