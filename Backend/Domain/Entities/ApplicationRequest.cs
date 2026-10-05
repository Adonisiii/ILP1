using Domain.Enums;

namespace Domain.Entities;

public class ApplicationRequest : BaseEntity
{
    public string ApplicationNumber { get; set; } = string.Empty;

    public string TaxPayerName { get; set; } = string.Empty;

    public string Nui { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string PhoneNumber { get; set; } = string.Empty;

    public string Manager { get; set; } = string.Empty;

    public CurrentStep CurrentStep { get; set; }

    public ApplicationStatus Status { get; set; }

    public ICollection<Activity> Activities { get; set; } = [];
}
