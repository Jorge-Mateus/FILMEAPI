using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsuarioAPI.Data.Dtos;
using UsuarioAPI.Service;

namespace UsuarioAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CadastroControllers : ControllerBase
    {
        private CadastroService _cadastroService;

        public CadastroControllers(CadastroService cadastroService)
        {
            _cadastroService = cadastroService;
        }

        [HttpPost]
        public IActionResult CadastrarUsuario(CreateUsuarioDto createDto)
        {
            Result resultado = _cadastroService.cadastrarUsuario(createDto);
            if (resultado.IsFailed) return StatusCode(500);
            return Ok();
        }
    }
}
