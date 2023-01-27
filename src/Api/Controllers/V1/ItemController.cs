using Application.Items.Command.CreateItem;
using Contracts.Items;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.V1;

[Route("[Controller]")]
public class ItemsController : ApiController
{
    private readonly IMapper _mapper;
    private readonly ISender _mediator;
    public ItemsController(IMapper mapper, IMediator mediator)
    {
        _mapper = mapper;
        _mediator = mediator;
    }

    [HttpPost("create")]
    public IActionResult CreateItem(ItemRequest request)
    {
        var command= _mapper.Map<CreateItemCommand>(request);
        var result = _mediator.Send(command);
        return Ok(result);
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello World");
    }
}
