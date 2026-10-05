namespace Domain.Entities
{
    public class AnnualPlanItems : BaseEntity
    {
        public string TariffNumber { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string UnitOfMeasurement { get; set; } = string.Empty;
        public string FinalProduct { get; set; } = string.Empty;
        public string Quantity { get; set; } = string.Empty;
        public string Remarks { get; set; } = string.Empty;
        public Guid AnnualPlanId { get; set; }
        public AnnualPlan AnnualPlan { get; set; } = null!;
    }
}
