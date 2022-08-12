namespace K2.Shared.Interfaces.Models
{
    public interface IAuditableUtc
    {
        bool IsDeleted { get; set; }
        DateTime CreatedAtUtc { get; set; }
        string CreatedBy { get; set; }
        DateTime UpdatedAtUtc { get; set; }
        string UpdatedBy { get; set; }
    }
}
