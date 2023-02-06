using Application.Common.Interfaces;
using Domain.Addresses.Entities;
using Domain.Items;
using Domain.Items.Entities;
using Domain.Vendors;
using ErrorOr;
using MediatR;
namespace Application.Items.Command.CreateItem;

public class CreateItemComandHandler : IRequestHandler<CreateItemCommand, ErrorOr<Item>>
{
    private readonly IItemRepository _itemRepository;
    public CreateItemComandHandler(IItemRepository itemRepository)
    {
        _itemRepository = itemRepository;
    }
    public async Task<ErrorOr<Item>> Handle(CreateItemCommand request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        //Create Item
        var item = Item.Create(request.Description,
                               request.SellingPrice,
                               request.CostPrice,
                               request.CostCode,
                               request.ReorderLevel,
                               request.ReorderQuantity,
                               request.TaxRatePercent,
                               request.LeadTime,
                               request.Created,
                               request.Modified,
                               request.Vendors.ConvertAll(v => Vendor.Create(
                                                         v.Name,
                                                         v.Fax,
                                                         v.Phone,
                                                         v.Email,
                                                         v.Website,
                                                         v.Contact,
                                                         v.ContactName,
                                                         v.ContactPhone,
                                                         v.ContactEmail,
                                                         v.Addresses.ConvertAll(a => Address.Create(a.AddressLine1,
                                                                                             a.AddressLine2,
                                                                                             a.City,
                                                                                             a.State,
                                                                                             a.ZipCode,
                                                                                             a.Country
                                                                                             )))),
                               request.Locations.ConvertAll(l => Location.Create(l.Name, l.QuantityOnHand, l.Notes))
                             );
        //Persist Item
        await _itemRepository.AddItemAsync(item, cancellationToken);

        //Return Item
        return item;
    }
}