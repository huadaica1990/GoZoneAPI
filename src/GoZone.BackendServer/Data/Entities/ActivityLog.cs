using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using GoZone.BackendServer.Data.Interfaces;

namespace GoZone.BackendServer.Data.Entities
{
    [Table("ActivityLogs")]
    public class ActivityLog : IDateTracking
    {
        #region Auto
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        #endregion

        #region Basic
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, MaxLength(50), Column(TypeName = "varchar(50)")]
        public string Action { get; set; }
        [Required, MaxLength(50), Column(TypeName = "varchar(50)")]
        public string EntityName { get; set; }
        [Required, MaxLength(50), Column(TypeName = "varchar(50)")]
        public string EntityId { get; set; }
        [MaxLength(256), Column(TypeName = "varchar(256)")]
        public string Url { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        #endregion

        #region Relationship
        [Required, MaxLength(50), Column(TypeName = "varchar(50)")]
        public string UserId { get; set; }
        #endregion
    }
}
