using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CommandAPI.Data;
using CommandAPI.Models;

namespace CommandAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : Controller
    {
        private readonly ICommandRepository repository;

        public CommandsController(ICommandRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commands = repository.GetAllCommands();

            return Ok(commands);
        }

        [HttpGet("{id}")]
        public ActionResult<Command> GetCommantById(int id)
        {
            var command = repository.GetCommandById(id);

            if (command == null)
            {
                return NotFound();
            }

            return Ok(command);
        }
    }
}
