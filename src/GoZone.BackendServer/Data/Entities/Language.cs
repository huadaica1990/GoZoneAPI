using GoZone.BackendServer.Data.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GoZone.BackendServer.Data.Entities
{
    [Table("Languages")]
    public class Language
    {

        #region Basic
        [Key, MaxLength(50), Column(TypeName = "varchar(50)")]
        public string Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Required, MaxLength(50)]
        public string Value { get; set; }
        [MaxLength(255), Column(TypeName = "varchar(255)")]
        public string Avatar { get; set; }
        public Status Status { get; set; }
        public bool IsDefault { get; set; }
        #endregion
    }
}
