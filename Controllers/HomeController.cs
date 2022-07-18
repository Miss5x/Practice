using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    [Route("/api/[controller]")] // адрес запроса
    public class HomeController : Controller 
    {
        [HttpPost()] // POST запрос из тела которого берутся параметры для метода Set
        public IActionResult Set([FromBody] InputDataModel inputData)
        {
            OutputDataModel outputData = new OutputDataModel(); // создаем экземпляр InputDataModel
            outputData.kod = Generetion.GetKod(inputData.lenght_kod); // вызов генерации кода
            outputData.salt = Generetion.GetSalt(inputData.lenght_salt); // вызов генерации соли
            outputData.hash = Generetion.GetSHA1(outputData.kod, outputData.salt); // хеширование
            return Ok(outputData); // возвращаем обьект класса InputDataModel
        }    
    }
}
