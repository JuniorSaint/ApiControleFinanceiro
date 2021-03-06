using System;
using System.Threading.Tasks;
using Api.Domain.Dtos.EntriesAmount;
using Api.Domain.Interfaces.Services;
using Api.Service.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntriesAmountController : ControllerBase
    {
        private IEntriesAmountService _service { get; set; }
        public EntriesAmountController(IEntriesAmountService service)
        {
            _service = service;
        }

        
      //  [Authorize("Bearer")]
        [HttpGet]
        [Route("{id}", Name = "GetEntriesWithId")]
        public async Task<ActionResult> Get(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var result = await _service.Get(id);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(await _service.Get(id));
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.InternalServerError, ex.Message);
            }
        }


    //    [Authorize("Bearer")]
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] EntriesAmountUpdate entries)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var result = await _service.Put(entries);
                if (result == null)
                {
                    return BadRequest();
                }
                return Ok(result);

            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.InternalServerError, ex.Message);
            }
        }

  //     [Authorize("Bearer")]
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await _service.Delete(id));
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.InternalServerError, ex.Message);
            }
        }

   //     [Authorize("Bearer")]
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] EntriesAmountDtoCreate entries)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var result = await _service.Post(entries);
                if (result != null)
                {
                    return Created(new Uri(Url.Link("GetEntriesWithId", new { id = result.Id })), result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.InternalServerError, ex.Message);
            }
        }


    //    [Authorize("Bearer")]
        [HttpGet]    
        public async Task<ActionResult> GetAll()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var result = await _service.GetAll();
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(await _service.GetAll());
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)System.Net.HttpStatusCode.InternalServerError, ex.Message);
            }
        }

    }
}
