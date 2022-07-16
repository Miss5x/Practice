using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    [Route("/api/[controller]")]
    public class HomeController : Controller
    {
        [HttpPost()]
        public IActionResult Set([FromBody] InputDataModel inputData)
        {
            OutputDataModel outputData = new OutputDataModel();
            outputData.kod = Generetion.GetKod(inputData.lenght_kod);
            outputData.salt = Generetion.GetSalt(inputData.lenght_salt);
            outputData.hash = Generetion.GetSHA1(outputData.kod, outputData.salt);
            return Ok(outputData);
        }    
    }
}
