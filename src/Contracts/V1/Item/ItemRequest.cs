namespace Contracts.Item
{
    public class ItemRequest
    {
        public Guid Id { get; set; }
        public required string Description { get; set; }
        public float QuantityOnHand { get; set; }
        public float SellingPrice { get; set; }
        public float CostPrice { get; set; }
        public string CostCode { get; set; } = default!;
        public Guid CategoryId { get; set; }
        public Guid UnitOfMeasure { get; set; }
        public int ReorderLevel { get; set; }
        public int ReorderQuantity { get; set; }
        public int TaxRatePercent { get; set; }
        public Guid Vendors { get; set; }
        public Guid Manufacturer { get; set; }
        public int LeadTime { get; set; }
    }
}
