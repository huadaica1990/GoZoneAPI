using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using GoZone.BackendServer.Data.Interfaces;

namespace GoZone.BackendServer.Data.Entities
{
    [Table("StaticPages")]
    public class StaticPage : IDateTracking, ISortable, IHasCreate
    {
        #region Auto
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int SortOrder { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }

        #endregion

        #region Basic
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string SeoSchema { get; set; }
        public string SeoRobot { get; set; }

        #endregion

        #region Relationship
        public virtual ICollection<StaticPageTranslate> StaticPageTranslates { get; set; }

        #endregion
    }
    [Table("StaticPageTranslates")]
    public class StaticPageTranslate : IHasSeo, IMultiLanguage
    {
        #region Auto
        public string SeoPageTitle { get; set; }
        public string SeoAlias { get; set; }
        public string SeoKeywords { get; set; }
        public string SeoDescription { get; set; }
        #endregion

        #region Basic
        [Required, MaxLength(256)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        #endregion

        #region Relationship
        [ForeignKey("LanguageId")]
        public virtual Language Languages { get; set; }
        [Required, Key, Column(Order = 0)]
        public string LanguageId { get; set; }

        [ForeignKey("StaticPageId")]
        public virtual StaticPage StaticPages { get; set; }
        [Required, Key, Column(Order = 1)]
        public int StaticPageId { get; set; }
        #endregion
    }
}
