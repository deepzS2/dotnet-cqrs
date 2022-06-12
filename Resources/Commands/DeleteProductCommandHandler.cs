using CQRS.Contexts;
using CQRS.Models;
using MediatR;

namespace CQRS.Resources.Commands;

public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, Product>
{
  private readonly AppDbContext _context;
  public DeleteProductCommandHandler(AppDbContext context)
  {
    _context = context;
  }

  public async Task<Product> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
  {
    var product = _context.Products.Where(p => p.Id == request.Id).FirstOrDefault();
    _context.Remove(product);

    await _context.SaveChangesAsync();
    return product;
  }
}