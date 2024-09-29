using Backend.Domain.Interfaces;
using Backend.Repo;

namespace BackendTemplate.DependencyExtensions
{
  public static class RegisterRepository
  {
    public static void AddRepositories(this IServiceCollection services)
    {
      services.AddScoped<IAuthRepository, AuthRepository>();
    }
  }
}
