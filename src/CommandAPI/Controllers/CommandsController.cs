using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CommandAPI.Data;
using CommandAPI.Models;
using AutoMapper; 
using CommandAPI.Dtos;


namespace CommandAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase 
    // if we inherit from Controller and not ControllerBase, it will also provide additional support which we dont need
    {
        private readonly ICommandAPIRepo _repository;
        private readonly IMapper _mapper;
        public CommandsController(ICommandAPIRepo repository, IMapper mapper)
        {
        _repository = repository;
        _mapper = mapper;
        }

        
        // [HttpGet]
        // public ActionResult<IEnumerable<Command>> GetAllCommands()
        // {
        // var commandItems = _repository.GetAllCommands();
        // return Ok(commandItems);
        // }

        /************** USING DTOs TO SEND RESPONSE TO THE CLIENT ****************/
        [HttpGet]
        public ActionResult<IEnumerable<CommandReadDto>> GetAllCommands()
        {
        var commandItems = _repository.GetAllCommands();
        return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commandItems));
        }
        /**************************************************************************/

        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandByIds(int id)
        {
        var commandItem = _repository.GetCommandById(id);
        if (commandItem == null)
        {
            return NotFound();
        }
        return Ok(commandItem);
        }


        [HttpPost]
        public ActionResult<Command> createCommands(Command cmd)
        {
        var commandItem = _repository.CreateCommand(cmd);
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

        
        [HttpPut("{id}")]
        public ActionResult<string> updateCommand(Command cmd, int id)
        {
            var commandModelFromRepo = _repository.GetCommandById(id);
            if (commandModelFromRepo == null)
            {
                return NotFound("No record to update");
            }
            else{
                var commandItem = _repository.UpdateCommand(cmd, id);
                return (commandItem);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<string> deleteCommand(int id)
        {
        var commandItem = _repository.DeleteCommand(id);
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