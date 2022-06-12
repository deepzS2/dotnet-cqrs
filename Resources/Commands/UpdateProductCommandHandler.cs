using CQRS.Contexts;
using CQRS.Models;
using MediatR;

namespace CQRS.Resources.Commands;

public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Product>
{
  private readonly AppDbContext _context;
  public UpdateProductCommandHandler(AppDbContext context)
  {
    _context = context;
  }

  public async Task<Product?> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
  {
    var product = _context.Products.Where(p => p.Id == request.Id).FirstOrDefault();

    if (product == null)
    {
      return default;
    }
    else
    {
      product.BarCode = request.BarCode;
      product.Name = request.Name;
      product.Price = request.Price;
      product.Fee = request.Fee;
      product.Description = request.Description;

      await _context.SaveChangesAsync();

      return product;
    }
  }
}