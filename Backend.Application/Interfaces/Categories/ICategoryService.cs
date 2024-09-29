using Backend.Application.Dto.Request;
using Backend.Application.Dto.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Application.Interfaces.Categories
{
  public interface ICategoryService
  {
    #region Get
    Task<CategoryResponse> GetCategory(int id);
    Task<CategoryResponse> GetAllCategories();
    #endregion Get

    #region Save
    Task<CategoryResponse> AddCategory(CategoryRequest categoryRequest, int createdBy);
    #endregion Save

    #region Update
    Task<CategoryResponse> UpdateCategory(CategoryRequest categoryRequest, int id);
    #endregion Update

    #region Delete
    Task<CategoryResponse> DeleteCategory(int id);
    #endregion Delete
  }
}
