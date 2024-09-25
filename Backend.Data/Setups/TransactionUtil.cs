using Backend.Domain.Contexts;
using Backend.Domain.Interfaces;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Data.Setups
{
  public class TransactionUtil : ITransactionUtil
  {
    private IApplicationDbContext _context { get; set; }
    private IDbContextTransaction _dbContextTransaction { get; set; }
    public TransactionUtil(IApplicationDbContext context)
    {
      _context = context ?? throw new ArgumentNullException(nameof(context));
    }
    public async Task BeginAsync()
    {
      _dbContextTransaction = await _context.Database.BeginTransactionAsync();
    }
    public async Task CommitAsync()
    {
      await _dbContextTransaction.CommitAsync();
    }
    public async Task RollBackAsync()
    {
      await _dbContextTransaction.RollbackAsync();
      await _dbContextTransaction.DisposeAsync();
    }
    public void Dispose()
    {
      if (_dbContextTransaction != null)
      {
        _dbContextTransaction.Dispose();
      }
      _context.Dispose();
    }
  }
}
