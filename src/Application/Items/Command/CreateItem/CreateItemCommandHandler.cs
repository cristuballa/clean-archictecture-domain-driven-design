using Domain.Items;
using ErrorOr;
using MediatR;
namespace Application.Items.Command.CreateItem;

public class CreateItemComandHandler : IRequestHandler<CreateItemCommand, ErrorOr<Item>>
{
    public Task<ErrorOr<Item>> Handle(CreateItemCommand request, CancellationToken cancellationToken)
    {
      //Create Item
       var item= Item.Create(request.Name,
                             request.Description,
                             request.SellingPrice,
                             request.CostPrice,
                             request.ReorderLevel,
                             request.taxRatePercent,
                             request.LeadTime,
                             request.Vendors,
                             request.Locations,
                             request.Created,
                             request.Modified);
      //Persist Item
      //Return Item
      return default!;
    }
}