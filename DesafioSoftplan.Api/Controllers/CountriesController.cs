using DesafioSoftplan.Services.Dtos;
using DesafioSoftplan.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DesafioSoftplan.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly ICountryService _countryService;

        public CountriesController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        // GET: api/<UsuariosController>
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _countryService.GetAsync());
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
                return Ok(await _countryService.GetAsync(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<UsuariosController>
        [HttpPost]
        public async Task<IActionResult> Post(CountryDto obj)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    return Ok(await _countryService.AddAsync(obj));
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
        public async Task<IActionResult> Put(CountryDto obj)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //var register = await _usuarioService.GetAsync(obj.Id);
                    //if (register == null) return BadRequest("Registro não encontrado com o Id informado");

                    return Ok(await _countryService.EditAsync(obj));
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
                var register = await _countryService.GetAsync(id);
                if (register == null) return BadRequest("Registro não encontrado com o Id informado");

                await _countryService.DeleteAsync(id);
                return Ok("Registro excluído");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}