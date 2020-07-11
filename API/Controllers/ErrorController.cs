using API.Errors;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  public class ErrorController : BaseApiController
  {
    private readonly StoreContext _context;

    public ErrorController(StoreContext context)
    {
      _context = context;
    }

    [HttpGet("notfound")]
    public ActionResult GetNotFoundRequest()
    {
      var item = _context.Products.Find(333);

      if (item == null)
      {
        return NotFound(new ApiResponse(404));
      }

      return Ok();
    }

    [HttpGet("servererror")]
    public ActionResult GetServerError()
    {
      var item = _context.Products.Find(333);

      var itemToReturn = item.ToString();

      return Ok();
    }

    [HttpGet("badrequest")]
    public ActionResult GetBadRequest()
    {
      return BadRequest(new ApiResponse(400));
    }

    [HttpGet("badrequest/{id}")]
    public ActionResult GetNotFoundRequest(int id)
    {
      return Ok();
    }
  }
}