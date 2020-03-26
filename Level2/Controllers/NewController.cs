using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Level2.Controllers
{
    public class NewController : Controller
    {
        public IActionResult Index()
        {
            //Add Docker support with Visual Studio and Run the API and the Server in Docker from Visual Studio and add Nuget packages and add migrations and add docker image for MSSQL server and deploy your WebAPI to a docker container
            return View();
        }
    }
}