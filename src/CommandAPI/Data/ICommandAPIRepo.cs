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
        Command CreateCommand(Command cmd);
        string CreateCommand2(Command cmd);
        string UpdateCommand(Command cmd, int id);
        string DeleteCommand(int id);
        //void DeleteCommand(Command cmd);
    }
}