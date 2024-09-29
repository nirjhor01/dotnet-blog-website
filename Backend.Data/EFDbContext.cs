using Backend.Domain.Contexts;
using Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Data
{
  public partial class EFDbContext: DbContext, IApplicationDbContext
  {

    #region Constructor
    public EFDbContext()
    {

    }

    public EFDbContext(DbContextOptions<EFDbContext> options) : base(options)
    {

    }


    #endregion Constructor

    #region DbSets
    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<PostCategory> PostCategories { get; set; }
    #endregion DbSets




  }
}
