using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index() 
        {
            return View();// invocar View Index
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name="Gabriela", int numTimes=1)
        {
            //return HtmlEncoder.Default.Encode($"Hello {name},ID: {ID}");//retorna a em HTML frase especificada, o "$" descodifica o valor das variaveis
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}