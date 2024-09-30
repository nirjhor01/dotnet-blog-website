using AutoMapper;
using Backend.Application.CustomExceptions;
using Backend.Application.Dto.Request;
using Backend.Application.Dto.Response;
using Backend.Application.Interfaces.Categories;
using Backend.Domain.Categories;
using Backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Service.Categories
{
  public class CategoryService : ICategoryService
  {
    public readonly ICategoryRepository _categoryRepository;
    public readonly IMapper _mapper;
    public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;

    }
    #region Private
    private async Task<Category> ValidateCategoryUpdateRequest(int id)
    {
      var existedCategory = await _categoryRepository.GetByIdAsync(id);
      if(existedCategory == null)
      {
        throw new ClientCustomException("Category not found", new()
                {
                    {"Id", "Category Id is not valid." }
                });
      }
      return existedCategory;
      
    }
    #endregion Private
    #region Save
    public async Task<CategoryResponse> AddCategory(CategoryRequest categoryRequest, int createdBy)
    {
      var categoryEntity = _mapper.Map<Category>(categoryRequest);
      await _categoryRepository.AddAsync(categoryEntity);
      await _categoryRepository.SaveChangesAsync();
      var res = _mapper.Map<CategoryResponse>(categoryEntity);
      return res;
    }
    #endregion Save

    #region Delete
    public async Task<CategoryResponse> DeleteCategory(int id)
    {
      var res = await ValidateCategoryUpdateRequest(id);
      var findTagetedCategoryEntity = await _categoryRepository.GetByIdAsync(id);
      if (findTagetedCategoryEntity is null)
      {
        throw new ClientCustomException("Category not found", new()
                {
                    {"Id", "Category Id is not valid." }
                });
      }
      //var MappedResponse = _mapper.Map<Category>(findTagetedCategoryEntity);
      await _categoryRepository.DeleteAsync(findTagetedCategoryEntity);
      await _categoryRepository.SaveChangesAsync();
      var deletedCategoryResponse = _mapper.Map<CategoryResponse>(findTagetedCategoryEntity);
      return deletedCategoryResponse;

    }
    #endregion Delete

    public Task<CategoryResponse> GetAllCategories()
    {
      throw new NotImplementedException();
    }

    public Task<CategoryResponse> GetCategory(int id)
    {
      throw new NotImplementedException();
    }
    #region Update
    public async Task<CategoryResponse> UpdateCategory(CategoryRequest categoryRequest, int id)
    {
      var res = await ValidateCategoryUpdateRequest(id);
      res.Name = categoryRequest.Name ?? res.Name;
      res.Route = categoryRequest.Route ?? res.Route;
      await _categoryRepository.UpdateAsync(res);
      await _categoryRepository.SaveChangesAsync();
      var response = _mapper.Map<CategoryResponse>(res);
      return response;

    }
    #endregion Update
  }
}
