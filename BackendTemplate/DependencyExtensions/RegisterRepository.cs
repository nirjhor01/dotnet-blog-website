using Backend.Domain.Categories;
using Backend.Domain.Interfaces;
using Backend.Domain.Interfaces.Posts;
using Backend.Repo;
using Backend.Repo.Categories;
using Backend.Repo.Posts;

namespace BackendTemplate.DependencyExtensions
{
  public static class RegisterRepository
  {
    public static void AddRepositories(this IServiceCollection services)
    {
      services.AddScoped<IAuthRepository, AuthRepository>();
      services.AddScoped<ICategoryRepository, CategoryRepository>();
      services.AddScoped<IPostRepository, PostRepository>();
    }
  }
}
