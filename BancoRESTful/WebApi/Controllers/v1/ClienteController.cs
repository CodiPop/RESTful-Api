using Application.Features.Clientes.Comands.CreateClienteCommand;
using Application.Features.Clientes.Comands.DeleteClienteCommand;
using Application.Features.Clientes.Comands.UpdateClienteCommand;
using Application.Features.Clientes.Queries.GetClienteById;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.v1
{
    [ApiVersion("1.0")]
    public class ClienteController : BaseApiController
    {

        //GET api/<controller>/
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await Mediator.Send(new GetClienteByIdQuery { Id = id }));
        }



        //POST api/<controller>

        [HttpPost]
        public async Task<IActionResult> Post(CreateClienteCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        //PUT api/<controller>/5

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id,UpdateClienteCommand command)
        {
            if (id != command.Id)
                return BadRequest();

            return Ok(await Mediator.Send(command));
        }



        //Delete api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id, DeleteClienteCommand command)
        {
            if (id != command.Id)
                return BadRequest();

            return Ok(await Mediator.Send(new DeleteClienteCommand { Id =id}));
        }
    }
}
