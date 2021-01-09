using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CommandAPI.Data;
using CommandAPI.Models;

namespace CommandAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase 
    // if we inherit from Controller and not ControllerBase, it will also provide additional support which we dont need
    {
        private readonly ICommandAPIRepo _repository;
        public CommandsController(ICommandAPIRepo repository)
        {
        _repository = repository;
        }

        
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
        var commandItems = _repository.GetAllCommands();
        return Ok(commandItems);
        }

        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandByIds(int id)
        {
        var commandItem = _repository.GetCommandById(id);
        if (commandItem == null)
        {
            return NotFound();
        }
        Console.WriteLine("okay");
        return Ok(commandItem);
        }


        [HttpPost]
        public ActionResult<string> createCommands(Command cmd)
        {
        var commandItem = _repository.CreateCommand(cmd);
        //Console.WriteLine(cmd.HowTo);
        return Ok(commandItem);
        }


        // WE MAY NOT USE AN INTERFACE(REPOSITORY) AT ALL TO CREATE AN ENDPOINT
        [HttpPost("habeeb")]
        public ActionResult<Command> createCommands2(Command cmd)
        {
        //var commandItem = _repository.CreateCommand2(cmd);  
        //Console.WriteLine(cmd.HowTo);
        return Ok(new Command{
            Id = 0,
            HowTo = "great",
            Platform = ".net",
            CommandLine = "normal"
        });
        }

        
        [HttpPatch]
        public ActionResult<string> updateCommand(Command cmd)
        {
        var commandItem = _repository.UpdateCommand(cmd);
        return (commandItem);
        }


        // OLD CONTROLLER WITHOUT THE USE OF INTERFACE
        // [HttpGet]
        // public ActionResult<IEnumerable<string>> Get()
        // {
        //     return new string[] {"this", "is", "hard", "coded"};
        // }
    }
}