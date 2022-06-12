using CQRS.Contexts;
using CQRS.Models;
using MediatR;

namespace CQRS.Resources.Commands;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Product>
{
  private readonly AppDbContext _context;
  public CreateProductCommandHandler(AppDbContext context)
  {
    _context = context;
  }

  public async Task<Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
  {
    var product = new Product();
    product.BarCode = request.BarCode;
    product.Name = request.Name;
    product.Price = request.Price;
    product.Fee = request.Fee;
    product.Description = request.Description;

    _context.Products.Add(product);
    await _context.SaveChangesAsync();

    return product;
  }
}