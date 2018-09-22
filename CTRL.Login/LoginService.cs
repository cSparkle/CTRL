using CTRL.Domain.Classes;
using CTRL.Domain.Interfaces;
using CTRL.Login.Interfaces;

namespace CTRL.Login
{
    public class LoginService : ILoginService
    {
        ILoginRepository _loginRepository;

        public LoginService(ILoginRepository repository)
        {
            _loginRepository = repository;
        }

        public UserProfile GetUser(LoginContract contract)
        {
            var user = _loginRepository.GetUser(contract);
            return user;
        }
    }
}
