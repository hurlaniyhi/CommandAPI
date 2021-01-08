using System;
using System.Collections.Generic;
using CommandAPI.Models;

namespace CommandAPI.Data
{
    public class MockCommandAPIRepo : ICommandAPIRepo  // we want this class to implement ICommandAPIRepo interface
    {
        public string CreateCommand(Command cmd)
        {
            // throw new System.NotImplementedException();
            Console.WriteLine(cmd.Platform);
            return "Product created";
        }

         public string CreateCommand2(Command cmd)
        {
            // throw new System.NotImplementedException();
            Console.WriteLine(cmd.Platform);
            return "Product created 2";
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            //throw new System.NotImplementedException();
             var commands = new List<Command>
            {
                new Command{
                Id=0, HowTo="How to generate a migration",
                CommandLine="dotnet ef migrations add <Name of Migration>",
                Platform=".Net Core EF"},
                new Command{
                Id=1, HowTo="Run Migrations",
                CommandLine="dotnet ef database update",
                Platform=".Net Core EF"},
                new Command{
                Id=2, HowTo="List active migrations",
                CommandLine="dotnet ef migrations list",
                Platform=".Net Core EF"}
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            //throw new System.NotImplementedException();
            return new Command{
            Id=0, HowTo="How to generate a migration",
            CommandLine="dotnet ef migrations add <Name of Migration>",
            Platform=".Net Core EF"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public string UpdateCommand(Command cmd)
        {
            //throw new System.NotImplementedException();
            return "updated";
        }
    }
}