using Postgrest.Attributes;
using Postgrest.Models;

namespace TardyQuery.Models {
    [Table("debugStudents")]
    class Students : BaseModel {
        [PrimaryKey("lrn_id")]
        public string? LrnId { get; set; }

        [Column("name")]
        public string? Name { get; set; }

        [Column("section")]
        public string? Section { get; set; }

        [Column("tardy_datetimes")]
        public DateTime[]? TardyDatetimeList { get; set; }
    }
}
