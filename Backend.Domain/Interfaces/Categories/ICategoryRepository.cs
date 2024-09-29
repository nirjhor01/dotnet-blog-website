using Backend.Domain.Entities;
using Backend.Domain.Interfaces;

namespace Backend.Domain.Categories
{
  public interface ICategoryRepository :IBaseRepository<Category>
  {
    Task<List<int>> VerifyCategory(List<int> categoryIds);
  }
}
