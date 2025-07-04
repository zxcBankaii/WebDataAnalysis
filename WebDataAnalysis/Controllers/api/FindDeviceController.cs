using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebDataAnalysis.Application.UseCase.FindDevices.AllCountFindDevicesByCategory;

namespace WebDataAnalysis.Controllers.api;

[Route("api/find-device")]
public class FindDeviceController : Controller
{
    private readonly IMediator _mediator;

    public FindDeviceController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("get-all-count")]
    public async Task<ActionResult<List<AllCountFindDevicesByCategoryResponse>>> GetAllCountFindDeviceCategory(CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(new AllCountFindDevicesByCategoryCommand(), cancellationToken);

        if (!result.IsSuccess)
        {
            return StatusCode(result.StatusCode, result.Error);
        }

        return result.Data;
    }
}