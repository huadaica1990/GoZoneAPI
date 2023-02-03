using GoZone.BackendServer.Data.Enums;
using GoZone.BackendServer.Data.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoZone.BackendServer.Data.Entities
{
    [Table("Contacts")]
    public class Contact : IDateTracking, IHasCreate
    {
        #region Auto
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        #endregion
        #region Basic
        [Key, MaxLength(50), Column(TypeName = "varchar(50)")]
        public string Id { get; set; }

        [Required, MaxLength(255)]
        public string Name { get; set; }
        public string Content { get; set; }
        public ContactStatus ContactStatus { get; set; }
        #endregion
    }
}
