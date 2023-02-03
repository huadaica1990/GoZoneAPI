using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GoZone.BackendServer.Data.Interfaces
{
    public interface IHasSeo
    {
        [Required, StringLength(70)]
        string SeoPageTitle { get; set; }
        [Required, StringLength(255), Column(TypeName = "varchar(255)")]
        string SeoAlias { get; set; }
        [StringLength(255)]
        string SeoKeywords { get; set; }
        [StringLength(160)]
        string SeoDescription { get; set; }
    }
}
