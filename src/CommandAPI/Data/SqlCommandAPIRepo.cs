using System;
using System.Linq;
using System.Collections;
using Newtonsoft.Json; // dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson
using System.Collections.Generic;
using CommandAPI.Models;

namespace CommandAPI.Data
{
    public class SqlCommandAPIRepo : ICommandAPIRepo
    {
        /***** Injecting DBContext to our repository *****/
        private readonly CommandContext _context;
        public SqlCommandAPIRepo(CommandContext context)
        {
            _context = context;
        }
        /***************************************************/
        public Command CreateCommand(Command cmd)
        {
            //throw new System.NotImplementedException();
            if(cmd == null){
                throw new ArgumentNullException(nameof(cmd));
            }
           _context.CommandItems.Add(cmd);
           _context.SaveChanges();
           return _context.CommandItems.First(i => i.Id == cmd.Id);
        }

        public string CreateCommand2(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public string DeleteCommand(int id)
        {
            //throw new System.NotImplementedException();
            var deleteMe = _context.CommandItems.First(i => i.Id == id);
                _context.CommandItems.Remove(deleteMe);
                _context.SaveChanges();
            return "information deleted";
        }

        public IEnumerable<Command> GetAllCommands()
        {
            // throw new System.NotImplementedException();
            return _context.CommandItems.ToList();
        }

        public Command GetCommandById(int id)
        {
            //throw new System.NotImplementedException();
            return _context.CommandItems.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public string UpdateCommand(Command cmd, int id)
        {
            //throw new System.NotImplementedException();
            // string json = JsonConvert.SerializeObject(cmd, Formatting.Indented);
            // Console.WriteLine(json);
            var changeMe = _context.CommandItems.First(i => i.Id == id);
            changeMe.Platform = cmd.Platform;
            changeMe.HowTo = cmd.HowTo;
            changeMe.CommandLine = cmd.CommandLine;
            _context.SaveChanges();
            return "Information updated";

        }
    }
}