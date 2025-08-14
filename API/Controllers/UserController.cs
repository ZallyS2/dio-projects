using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase {
        [HttpGet("ObterDataHora")]
        public IActionResult ObterDataHora() {

            var obj = new {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToLongTimeString(),

                UtcOffset = TimeZoneInfo.Local.BaseUtcOffset.ToString()
            };

            return Ok(obj);
        }


        [HttpGet("Apresentar/{nome}")]
        public IActionResult Apresentar(string nome) {
            var mensagem = $"Olá {nome}! Esta é a minha primeira API com ASP.NET Core.";
            return Ok(new { mensagem });
        }
    }
}