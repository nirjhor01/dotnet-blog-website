using Backend.Application.Dto.Request;
using Backend.Application.Dto.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Application.Interfaces.Posts
{
  public interface IPostService
  {
    public  Task<PostResponse> AddPosts(PostRequest post, int AuthorId);
    public Task<PostResponse> UpdatePosts(PostRequest post, int PostId);
    public Task<PostResponse> DeletePosts(int id);

  }
}
