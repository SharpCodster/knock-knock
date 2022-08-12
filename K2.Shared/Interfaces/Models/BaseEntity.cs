using System.ComponentModel.DataAnnotations.Schema;

namespace K2.Shared.Interfaces.Models
{
    public class BaseEntity : IIdentified, IAuditableUtc
    {
        [Column(Order = 0)]
        public string Id { get; set; }


        [Column(Order = 10000)]
        public DateTime CreatedAtUtc { get; set; }
        [Column(Order = 10001)]
        public string CreatedBy { get; set; }
        [Column(Order = 10002)]
        public DateTime UpdatedAtUtc { get; set; }
        [Column(Order = 10003)]
        public string UpdatedBy { get; set; }
        [Column(Order = 10004)]
        public bool IsDeleted { get; set; }
    }
}
