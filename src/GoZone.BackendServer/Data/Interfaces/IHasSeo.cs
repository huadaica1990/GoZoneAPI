using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GoZone.BackendServer.Data.Interfaces
{
    public interface IHasSeo
    {
        [Required, StringLength(70)]
        string SeoPageTitle { get; set; }
        [Required, StringLength(256), Column(TypeName = "varchar(256)")]
        string SeoAlias { get; set; }
        [StringLength(256)]
        string SeoKeywords { get; set; }
        [StringLength(160)]
        string SeoDescription { get; set; }
    }
}
