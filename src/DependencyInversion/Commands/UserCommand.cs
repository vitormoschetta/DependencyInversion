using System;

namespace DependencyInversion.Commands
{
    public class UserCommand
    {
        public UserCommand() { }
        public UserCommand(string name)
        {
            Name = name;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}