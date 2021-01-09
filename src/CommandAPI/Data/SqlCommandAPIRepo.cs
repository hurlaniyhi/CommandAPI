using System.Linq;
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
        public string CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public string CreateCommand2(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
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

        public string UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}