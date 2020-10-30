using DependencyInversion.Commands;
using DependencyInversion.Interfaces;

namespace Tests.Mock
{
    public class UserRepositoryFake : IUserRepository
    {
        public void Create(UserCommand command)
        {

        }
    }
}