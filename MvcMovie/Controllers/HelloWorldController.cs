using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        public string Index()
        {
            return "This is my default action...?";
        }

        // GET: /HelloWorld/Welcome/
        /*http://localhost:52331/HelloWorld/Welcome
         * public string Welcome() {
           return "This is the Welcome action method...";
             }
        */

        // GET: /HelloWorld/Welcome/
        //http://localhost:52331/HelloWorld/Welcome/78?name=Rogelio%20Quin%20Rom
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID = {ID}");
        }

        // GET: /HelloWorld/Contacts/
        // Requires using System.Text.Encodings.Web
        //http://localhost:52331/HelloWorld/contacts?name=Rogelio%20Quintana%20Romero&numTimes=5
        public string Contacts(string name, int numTimes=1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}
