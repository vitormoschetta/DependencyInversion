using System;

namespace DependencyInversion.Commands
{
    public class GroupCommand
    {
        public GroupCommand() { }
        public GroupCommand(string name)
        {
            Name = name;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}