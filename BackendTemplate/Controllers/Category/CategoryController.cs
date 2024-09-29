using Backend.Application.Dto.Request;
using Backend.Application.Dto.Response;
using Backend.Application.Interfaces.Categories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendTemplate.Controllers.Category
{
  [Route("api/category-management")]
  [ApiController]
  public class CategoryController : ControllerBase
  {
    #region Properties
    public readonly ICategoryService _categoryService;
    #endregion Properties

    #region ctor
    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }
    #endregion ctor

    #region SAVE
    [HttpPost]
    [Route("category")]
    [AllowAnonymous]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CategoryResponse))]
    public async Task<IActionResult> AddCategory([FromBody] CategoryRequest categoryRequest)
    {
      var res = await _categoryService.AddCategory(categoryRequest, 1);
      return Ok(res); 
    }
    #endregion SAVE

  }
}
