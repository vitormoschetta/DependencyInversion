using DependencyInversion.Commands;
using DependencyInversion.Interfaces;
using DependencyInversion.Repositories;

namespace DependencyInversion.Handlers
{
    public class ProductHandler
    {
        private readonly ProductRepository _repository;
        public ProductHandler(ProductRepository repository)
        {
            _repository = repository;
        }
        public CommandResult Create(ProductCommand command)
        {
            return new CommandResult(true, "Message");
        }
    }
}