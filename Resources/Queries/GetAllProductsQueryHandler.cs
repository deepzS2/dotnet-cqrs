using CQRS.Contexts;
using CQRS.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRS.Resources.Queries;

public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<Product>>
{
  private readonly AppDbContext _context;
  public GetAllProductsQueryHandler(AppDbContext context)
  {
    _context = context;
  }
  public async Task<IEnumerable<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
  {
    return await _context.Products.ToListAsync();
  }
}