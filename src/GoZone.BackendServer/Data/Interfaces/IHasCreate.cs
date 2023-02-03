using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GoZone.BackendServer.Data.Interfaces
{
    public interface IHasCreate
    {
        [MaxLength(50), Column(TypeName = "varchar(50)")]
        string CreateBy { get; set; }
        [MaxLength(50), Column(TypeName = "varchar(50)")]
        string UpdateBy { get; set; }
    }
}
