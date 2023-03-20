namespace Api.Controllers.v1;

using MediatR;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class ColorController : BaseApiController
{
    private readonly IMediator mediator;

    public ColorController(IMediator mediator) => this.mediator = mediator;

    //[HttpGet("{id:guid}")]
    //public Task<Color> GetAsync(Guid id)
    //{
    //    //return Mediator.Send(new ColorQuery());
    //}
}
