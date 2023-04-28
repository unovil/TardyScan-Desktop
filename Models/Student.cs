using Postgrest.Attributes;
using Postgrest.Models;

namespace TardyQuery.Models {
    [Table("debugStudents")]
    class Student : BaseModel {
        #pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        [PrimaryKey("lrn_id")]
        public string LrnId { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("section")]
        public string Section { get; set; }
        #pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        [Column("tardy_datetimes")]
        public DateTime[]? TardyDatetimeList { get; set; }
    }
}
