using DesafioSoftplan.Services.Dtos;
using DesafioSoftplan.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DesafioSoftplan.Api.Controllers
{
    [Route("api/v2/Countries")]
    [Authorize]
    [ApiController]
    public class CountriesV2Controller : ControllerBase
    {
        private readonly ICountryV2Service _countryV2Service;

        public CountriesV2Controller(ICountryV2Service countryService)
        {
            _countryV2Service = countryService;
        }

        // GET: api/<UsuariosController>
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _countryV2Service.GetAsync());
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
                return Ok(await _countryV2Service.GetAsync(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<UsuariosController>
        [HttpPost]
        public async Task<IActionResult> Post(CountryV2Dto obj)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    return Ok(await _countryV2Service.AddAsync(obj));
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
        public async Task<IActionResult> Put(CountryV2Dto obj)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //var register = await _usuarioService.GetAsync(obj.Id);
                    //if (register == null) return BadRequest("Registro não encontrado com o Id informado");

                    return Ok(await _countryV2Service.EditAsync(obj));
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
                var register = await _countryV2Service.GetAsync(id);
                if (register == null) return BadRequest("Registro não encontrado com o Id informado");

                await _countryV2Service.DeleteAsync(id);
                return Ok("Registro excluído");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}