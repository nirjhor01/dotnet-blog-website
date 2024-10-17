using Backend.Application.Dto.Request;
using Backend.Application.Dto.Response;
using Backend.Application.Interfaces.Posts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace BackendTemplate.Controllers.Post
{
  [Route("api/post-management")]
  [ApiController]
  public class PostController : ControllerBase
  {
    private readonly IPostService _postService;
    public PostController(IPostService postService)
    {
        _postService = postService;
    }

    #region SAVE
    [HttpPost]
    [Route("post")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PostResponse))]
    public async Task<IActionResult> AddPosts([FromBody] PostRequest request)
    {
      var res = await _postService.AddPosts(request, 1);
      var json = JsonConvert.SerializeObject(res);
      return Content(json, "application/json");
    }
    #endregion SAVE

    #region Delete
    [HttpDelete]
    [Route("post")]
    public async Task<IActionResult> DeletePost(int id)
    {
      var res = await _postService.DeletePosts(id);
      return Ok(res);
    }
    #endregion Delete


  }
}
