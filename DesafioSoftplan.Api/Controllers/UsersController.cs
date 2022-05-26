using DesafioSoftplan.Services.Dtos;
using DesafioSoftplan.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DesafioSoftplan.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [Authorize]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: api/<UsuariosController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _userService.GetAsync());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<UsuariosController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                return Ok(await _userService.GetAsync(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<UsuariosController>
        [HttpPost]
        public async Task<IActionResult> Post(UserDto obj)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    return Ok(await _userService.AddAsync(obj));
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            return BadRequest(new BadRequestObjectResult(ModelState));
        }

        // PUT api/<UsuariosController>
        [HttpPut]
        public async Task<IActionResult> Put(UserDto obj)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var register = await _userService.EditAsync(obj);
                    if (register == null) return BadRequest("Registro não encontrado com o Id informado");

                    return Ok(await _userService.EditAsync(obj));
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            return BadRequest(new BadRequestObjectResult(ModelState));
        }

        // DELETE api/<UsuariosController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var register = await _userService.GetAsync(id);
                if (register == null) return BadRequest("Registro não encontrado com o Id informado");

                await _userService.DeleteAsync(id);
                return Ok("Registro excluído");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}