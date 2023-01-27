using Application.Items.Command.CreateItem;
using Contracts.Items;
using Mapster;

public class ItemMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<ItemRequest, CreateItemCommand>()
            .Map(dest => dest, src => src);
     }
}