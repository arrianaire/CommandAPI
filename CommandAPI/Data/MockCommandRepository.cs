using CommandAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CommandAPI.Data
{
    public class MockCommandRepository : ICommandRepository
    {
        public void CreateCommand(Command command)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command command)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            List<Command> commands = new List<Command>
            {
                new Command
                {
                    ID = 0,
                    HowTo = "How to run migrations",
                    CommandLine = "dotnet ef database update ",
                    Platform = ".NET Core Entity Framework"
                },
                new Command
                {
                    ID = 1,
                    HowTo = "How to generate a migration",
                    CommandLine = "dotnet ef migrations add <Name of Migration>",
                    Platform = ".NET Core Entity Framework"
                },
                new Command
                {
                    ID = 2,
                    HowTo = "How to list active migrations",
                    CommandLine = "dotnet ef migrations list",
                    Platform = ".NET Core Entity Framework"
                }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command
            {
                ID = 0,
                HowTo = "How to run migrations",
                CommandLine = "dotnet ef database update ",
                Platform = ".NET Core Entity Framework"
            };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command command)
        {
            throw new NotImplementedException();
        }
    }
}
