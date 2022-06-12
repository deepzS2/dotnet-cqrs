using CQRS.Contexts;
using CQRS.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRS.Resources.Queries;

public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Product>
{
  private readonly AppDbContext _context;
  public GetProductByIdQueryHandler(AppDbContext context)
  {
    _context = context;
  }
  public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
  {
    return await _context.Products.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
  }
}