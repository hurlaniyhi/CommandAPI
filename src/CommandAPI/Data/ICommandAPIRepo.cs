//
using System.Collections.Generic;
using CommandAPI.Models;

namespace CommandAPI.Data
{
    public interface ICommandAPIRepo
    {
        bool SaveChanges();
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        string CreateCommand(Command cmd);
        string CreateCommand2(Command cmd);
        string UpdateCommand(Command cmd);
        void DeleteCommand(Command cmd);
    }
}