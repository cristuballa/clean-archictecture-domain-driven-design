using Application.Items.Command.CreateItem;
using Contracts.Items;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.V1;

[Route("items")]
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
    public async Task<IActionResult> CreateItem(ItemRequest request)
    {
        var command = _mapper.Map<CreateItemCommand>(request);
        var createItemResult = await _mediator.Send(command);


        return createItemResult.Match(
                 item => Ok(_mapper.Map<ItemResponse>(item)),
                 errors => Problem(errors));
    }

    [HttpGet]
    public IActionResult GetItem()
    {
        return Ok("Hello World");
    }
}
