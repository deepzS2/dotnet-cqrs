
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CQRS.Models;

[Table("Products")]
public class Product
{
  public int Id { get; set; }

  [StringLength(80, MinimumLength = 4)]
  public string? Name { get; set; }

  public string? BarCode { get; set; }

  public bool Active { get; set; } = true;

  [StringLength(80, MinimumLength = 4)]
  public string? Description { get; set; }

  [Column(TypeName = "decimal(10, 2)")]
  public decimal Fee { get; set; }

  [Column(TypeName = "decimal(10, 2)")]
  public decimal Price { get; set; }
}