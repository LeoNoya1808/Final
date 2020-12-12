using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace final.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Operaciones : ControllerBase
    {
        [HttpGet]

        public string op(int numero)
        {
            if (numero == 0)
                return "Realizado por Leonardo";
            else if (numero < 0)
                return "ERROR";
            else
                return "https://image.freepik.com/vector-gratis/numeros-cartel-imagen_1639-6453.jpg";

        }
    }
}
