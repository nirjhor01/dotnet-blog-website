using Backend.Application.Interfaces.Auth;
using Backend.Application.Interfaces.Categories;
using Backend.Service;
using Backend.Service.Categories;

namespace BackendTemplate.DependencyExtensions
{
  public static class RegisterService
  {
    public static void AddServices(this IServiceCollection services)
    {
      #region A
      services.AddScoped<IAuthService, AuthService>();
      #endregion A
      #region C
      services.AddScoped<ICategoryService, CategoryService>();
      #endregion C
    }
  }
}
