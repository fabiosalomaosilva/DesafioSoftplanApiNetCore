using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioSoftplan.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class RepositoriosGitController : ControllerBase
    {
        // GET: api/<UsuariosController>
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Get()
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