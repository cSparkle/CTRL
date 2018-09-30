using CTRL.Domain.Classes;
using CTRL.Domain.Interfaces;
using CTRL.Login.Interfaces;

namespace CTRL.Login
{
    public class LoginService : ILoginService
    {
        ILoginRepository loginRepository;
        IAuthorizationService authorizationService;

        public LoginService(ILoginRepository repository, IAuthorizationService authorizationService)
        {
            this.loginRepository = repository;
            this.authorizationService = authorizationService;
        }

        public UserProfile GetUser(LoginContract contract)
        {
            var user = loginRepository.GetUser(contract);
            if (user.IsActive)
            {
                user.Permissions = authorizationService.GetUserPermissions(user);
            }

            return user;
        }
    }
}
