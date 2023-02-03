using GoZone.BackendServer.Data.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using GoZone.BackendServer.Data.Enums;

namespace GoZone.BackendServer.Data.Entities
{
    [Table("Orders")]
    public class Order : IDateTracking, IHasCreate
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
        [MaxLength(500)]
        public string Description { get; set; }
        public OrderStatus OrderStatus { get; set; }
        #endregion

        #region Relationship
        [Required, MaxLength(50), Column(TypeName = "varchar(50)")]
        public string OwnerId { get; set; }
        [Required, MaxLength(50), Column(TypeName = "varchar(50)")]
        public string CustomerId { get; set; }
        #endregion
    }

    [Table("OrderImages")]
    public class OrderImage
    {
        #region Basic
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, MaxLength(255)]
        public string Src { get; set; }
        #endregion

        #region Relationship
        [Required, MaxLength(50), Column(TypeName = "varchar(50)")]
        public string OrderId { get; set; }
        #endregion
    }

    [Table("OrderDetails")]
    public class OrderDetail
    {
        #region Basic
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required, MaxLength(255)]
        public string ProductName { get; set; }
        [MaxLength(255)]
        public string File { get; set; }
        [Required, DefaultValue(0)]
        public decimal Price { get; set; }
        [Required, DefaultValue(0)]
        public decimal PriceFee { get; set; }
        [Required, DefaultValue(0)]
        public decimal PriceTax { get; set; }
        public int Quanity { get; set; }
        #endregion

        #region Relationship
        [Required, MaxLength(50), Column(TypeName = "varchar(50)")]
        public string OrderId { get; set; }
        #endregion
    }
}
