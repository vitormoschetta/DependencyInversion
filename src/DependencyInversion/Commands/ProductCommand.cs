using System;

namespace DependencyInversion.Commands
{
    public class ProductCommand
    {
        public ProductCommand() { }
        public ProductCommand(string name)
        {
            Name = name;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}