using Backend.Data;
using Backend.Domain.Categories;
using Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Repo.Categories
{
  public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
  {
    private readonly EFDbContext _context;
    public CategoryRepository(EFDbContext context) : base(context)
    {
      _context = context;
    }

    #region VarifyCategory
    public async Task<List<int>> VerifyCategory(List<int> categoryIds)
    {

      var existingCategoryIds = await _context.Categories
          .Where(c => categoryIds.Contains(c.Id))
          .Select(c => c.Id)
          .ToListAsync();

      var notPresentCategoryIds = categoryIds.Except(existingCategoryIds).ToList();

      return notPresentCategoryIds;
    }
    #endregion VarifyCategory

  }
}
