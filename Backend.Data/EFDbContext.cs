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

    public DbSet<User> Users { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    #endregion Constructor

    #region DbSets
    #endregion DbSets

  }
}
