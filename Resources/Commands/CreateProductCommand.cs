
using CQRS.Models;
using MediatR;

namespace CQRS.Resources.Commands;

public class CreateProductCommand : IRequest<Product>
{
  public string? Name { get; set; }

  public string? BarCode { get; set; }

  public bool Active { get; set; } = true;

  public string? Description { get; set; }

  public decimal Fee { get; set; }

  public decimal Price { get; set; }
}