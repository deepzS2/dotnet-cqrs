using CQRS.Contexts;
using CQRS.Models;
using CQRS.Resources.Commands;
using CQRS.Resources.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
  private readonly IMediator _mediator;

  public ProductsController(AppDbContext context, IMediator mediator)
  {
    _mediator = mediator;
  }

  [HttpGet]
  public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
  {
    try
    {
      var command = new GetAllProductsQuery();
      var response = await _mediator.Send(command);
      return Ok(response);
    }
    catch (Exception ex)
    {
      return BadRequest(ex.Message);
    }
  }

  [HttpGet("{id:int}")]
  public async Task<ActionResult<Product>> GetProductById(int id)
  {
    try
    {
      var command = new GetProductByIdQuery { Id = id };
      var response = await _mediator.Send(command);
      return Ok(response);
    }
    catch (Exception ex)
    {
      return BadRequest(ex.Message);
    }
  }

  [HttpPost]
  public async Task<ActionResult<Product>> CreateProduct([FromBody] CreateProductCommand command)
  {
    try
    {
      var response = await _mediator.Send(command);
      return Ok(response);
    }
    catch (Exception ex)
    {
      return BadRequest(ex.Message);
    }
  }

  [HttpDelete("{id:int}")]
  public async Task<ActionResult<Product>> DeleteProduct(int id)
  {
    try
    {
      var command = new DeleteProductCommand { Id = id };
      var response = await _mediator.Send(command);
      return Ok(response);
    }
    catch (Exception ex)
    {
      return BadRequest(ex.Message);
    }
  }
  [HttpPut]
  public async Task<ActionResult<Product>> UpdateProduct([FromBody] UpdateProductCommand command)
  {
    try
    {
      var response = await _mediator.Send(command);
      return Ok(response);
    }
    catch (Exception ex)
    {
      return BadRequest(ex.Message);
    }
  }
}