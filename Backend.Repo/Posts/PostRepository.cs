using Backend.Data;
using Backend.Domain.Entities;
using Backend.Domain.Interfaces.Posts;

namespace Backend.Repo.Posts
{
  public class PostRepository : BaseRepository<Post>, IPostRepository
  {
    private readonly EFDbContext _context;
    public PostRepository(EFDbContext context) : base(context)
    {
      _context = context;
    }

  }
}
