using DependencyInversion.Commands;
using DependencyInversion.Interfaces;

namespace DependencyInversion.Controllers
{
    public class UserController
    {
        private readonly IUserHandler _handler;
        private readonly IUserRepository _repository;
        public UserController(IUserHandler handler, IUserRepository repository)
        {
            _handler = handler;
            _repository = repository;
        }

        public CommandResult Create(UserCommand command)
        {
            CommandResult commandResult = _handler.Create(command);
            return commandResult;
        }
    }
}