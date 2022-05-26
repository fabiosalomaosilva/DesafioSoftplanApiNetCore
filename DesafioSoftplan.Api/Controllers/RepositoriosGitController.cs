using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioSoftplan.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [AllowAnonymous]
    [ApiController]
    public class RepositoriosGitController : ControllerBase
    {
        // GET: api/<UsuariosController>
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var repos = new List<string>
                {
                    "https://github.com/fabiosalomaosilva/DesafioSoftplanReact",
                    "https://github.com/fabiosalomaosilva/DesafioSoftplanReact"
                };
                return Ok(repos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}