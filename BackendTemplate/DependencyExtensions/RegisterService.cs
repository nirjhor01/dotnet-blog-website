using Backend.Application.Interfaces.Auth;
using Backend.Service;

namespace BackendTemplate.DependencyExtensions
{
  public static class RegisterService
  {
    public static void AddServices(this IServiceCollection services)
    {
      #region A
      services.AddScoped<IAuthService, AuthService>();
      #endregion A
    }
  }
}
