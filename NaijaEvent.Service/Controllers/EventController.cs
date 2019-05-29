using System;
using System.Collections.Generic;

using System.Threading.Tasks;
using MediatR;

using Microsoft.AspNetCore.Mvc;
using NaijaEvent.Application.DTOs;
using NaijaEvent.Application.NEvents.Command.CreateEvent;
using NaijaEvent.Application.NEvents.Query;

namespace NaijaEvent.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EventController : ControllerBase
    {


        private readonly Mediator _mediator;
        public EventController(Mediator mediator)
        {
            _mediator = mediator;
        }

        [Route("api/[controller]")]

        [HttpGet]
        
        [ProducesResponseType(typeof(IEnumerable<NEventDTO>), statusCode:200)]
        public async Task<ActionResult<NEventDTO>> index()
        {
            return Ok(await _mediator.Send(new GetAllNEventQuery()));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<NEventDTO>> Get(Guid id)
        {
            return Ok(await _mediator.Send(new GetNEventDetails { nEventId = id }));
        }

        [HttpPost]
        [ProducesResponseType(typeof(Boolean),200)]
        public async Task<ActionResult<bool>> Create([FromBody] CreateEventCommand command)
        {


            var result = await _mediator.Send(command);


            return Ok(result.Successful);
        }

        //[HttpPut]
        //public async Task<ActionResult<NEventDTO>> Update([FromBody] UpdateProductCommand command)
        //{

        //    return Ok(await Mediator.Send(command));
        //}

        //[HttpDelete("{id}")]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        //[ProducesDefaultResponseType]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    await Mediator.Send(new DeleteProductCommand { Id = id });

        //    return NoContent();
        //}
    } }