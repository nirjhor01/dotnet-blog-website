using AutoMapper;
using Backend.Application.Dto.Request;
using Backend.Application.Dto.Response;
using Backend.Application.Interfaces.Posts;
using Backend.Domain.Entities;
using Backend.Domain.Interfaces.Posts;

namespace Backend.Service
{
  public class PostService : IPostService
  {
    private readonly IPostRepository _postRepository;
    private readonly IMapper _mapper;
    public PostService(IPostRepository postRepository, IMapper mapper)
    {
      _postRepository = postRepository;
      _mapper = mapper;
    }

    public async Task<PostResponse> AddPosts(PostRequest post, int AuthorId)
    {
      var PostEntity = _mapper.Map<Post>(post);
      var res = await _postRepository.AddAsync(PostEntity);
      await _postRepository.SaveChangesAsync();
      return _mapper.Map<PostResponse>(res);
    }

    public async Task<PostResponse> DeletePosts(int id)
    {
      var deletedEntity = await _postRepository.GetByIdAsync(id);
      //await _postRepository.DeleteAsync(deletedEntity);
      await _postRepository.SoftDeleteAsync(deletedEntity);
      return _mapper.Map<PostResponse>(deletedEntity);
    }

    public Task<PostResponse> UpdatePosts(PostRequest post, int id)
    {
      throw new NotImplementedException();
    }
  }
}
