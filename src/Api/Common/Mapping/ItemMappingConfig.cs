using Application.Items.Command.CreateItem;
using Contracts.Items;
using Domain.Addresses.Entities;
using Domain.Items;
using Domain.Items.Entities;
using Domain.Vendors;
using Mapster;
namespace Api.Common.Mapping;
public class ItemMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<ItemRequest, CreateItemCommand>()
            .Map(dest => dest, src => src);

        //     config.NewConfig<Item, ItemResponse>()
        //         .Map(dest => dest, src => src);
        //     config.NewConfig<Vendor, VendorResponse>()
        //         .Map(dest => dest, src => src);
        //     config.NewConfig<Address, AddressResponse>()
        //           .Map(dest => dest, src => src);
        //     config.NewConfig<Location, LocationResponse>()
        //   .Map(dest => dest, src => src);
    }
}