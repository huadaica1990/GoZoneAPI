using GoZone.BackendServer.Data.Enums;
using GoZone.BackendServer.Data.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoZone.BackendServer.Data.Entities
{
    [Table("Announcements")]
    public class Announcement : IDateTracking, ISwitchable
    {
        #region Auto
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public Status Status { get; set; }
        #endregion

        #region Basic
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, MaxLength(256)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Content { get; set; }
        #endregion

        #region Relationship
        public virtual ICollection<AnnouncementUser> AnnouncementUsers { get; set; }
        #endregion
    }

    [Table("AnnouncementUsers")]
    public class AnnouncementUser
    {
        #region Basic
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public bool? HasRead { get; set; }
        #endregion

        #region Relationship
        [Required, MaxLength(50), Column(TypeName = "varchar(50)")]
        public string UserId { get; set; }

        [ForeignKey("AnnouncementId")]
        public virtual Announcement Announcement { get; set; }
        [Required]
        public int AnnouncementId { get; set; }
        #endregion
    } 
}
