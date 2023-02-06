using Domain.Addresses.ValueObjects;
using Domain.Items;
using Domain.Items.ValueObjects;
using Domain.Vendors;
using Domain.Vendors.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class ItemConfiguration : IEntityTypeConfiguration<Item>
{
    public void Configure(EntityTypeBuilder<Item> builder)
    {
        ConfigureItemsTable(builder);
        ConfigureVendorsTable(builder);
        ConfigureLocationTable(builder);

    }

    private void ConfigureLocationTable(EntityTypeBuilder<Item> builder)
    {
        builder.OwnsMany(l => l.Locations, lb =>
        {
            lb.ToTable("Locations");
            lb.WithOwner().HasForeignKey("ItemId");
            lb.Property(l => l.Id)
                .HasColumnName("LocationId")
                .ValueGeneratedNever()
                .HasConversion(
                    id => id.Value,
                    value => LocationId.Create(value));

        });
    }

    private static void ConfigureVendorsTable(EntityTypeBuilder<Item> builder)
    {
        builder.OwnsMany(i => i.Vendors, vb =>
        {
            vb.ToTable("Vendors");
            vb.HasKey("Id", "ItemId");
            vb.WithOwner().HasForeignKey("ItemId");
            vb.Property(v => v.Id)
                .HasColumnName("VendorId")
                .ValueGeneratedNever()
                .HasConversion(
                    id => id.Value,
                    value => VendorId.Create(value));
            vb.OwnsMany(a => a.Addresses, ab =>
            {
                ab.ToTable("Addresses");
                ab.WithOwner().HasForeignKey("VendorId", "ItemId");
                ab.HasKey("Id", "VendorId", "ItemId");
                ab.Property(a => a.Id)
                    .HasColumnName("AddressId")
                    .ValueGeneratedNever()
                    .HasConversion(
                        id => id.Value,
                        value => AddressId.Create(value));
            });
        });
    }

    private static void ConfigureItemsTable(EntityTypeBuilder<Item> builder)
    {
        builder.ToTable("Items");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .HasConversion(
                id => id.Value,
                value => ItemId.Create(value));
    }
}