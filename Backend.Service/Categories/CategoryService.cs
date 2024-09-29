using AutoMapper;
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
    public async Task<CategoryResponse> AddCategory(CategoryRequest categoryRequest, int createdBy)
    {
      var categoryEntity = _mapper.Map<Category>(categoryRequest);
      await _categoryRepository.AddAsync(categoryEntity);
      await _categoryRepository.SaveChangesAsync();
      var res = _mapper.Map<CategoryResponse>(categoryEntity);
      return res;
    }

    public Task<CategoryResponse> DeleteCategory(int id)
    {
      throw new NotImplementedException();
    }

    public Task<CategoryResponse> GetAllCategories()
    {
      throw new NotImplementedException();
    }

    public Task<CategoryResponse> GetCategory(int id)
    {
      throw new NotImplementedException();
    }

    public Task<CategoryResponse> UpdateCategory(CategoryRequest categoryRequest, int id)
    {
      throw new NotImplementedException();
    }
  }
}
