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
        public Guid Id { get; set; }
        [Required, MaxLength(256)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public OrderStatus OrderStatus { get; set; }
        #endregion
        #region Price
        public decimal TotalAmount { get; set; }
        private decimal _moneyPaid;
        public decimal MoneyPaid
        {
            get
            {
                return _moneyPaid;
            }
            set
            {
                _moneyPaid = value;
                _moneyRecevied = _moneyPaid + _moneyTax;
            }
        }

        private decimal _moneyTax;
        public decimal MoneyTax
        {
            get
            {
                return _moneyTax;
            }
            set
            {
                _moneyTax = value;
                _moneyRecevied = _moneyPaid + _moneyTax;
            }
        }

        private decimal _moneyRecevied;
        public decimal MoneyRecevied
        {
            get
            {
                return _moneyRecevied;
            }
            private set
            {
                _moneyRecevied = value;
            }
        }
        #endregion

        #region Relationship
        [Required, MaxLength(50), Column(TypeName = "varchar(50)")]
        public string OwnerId { get; set; }
        [Required, MaxLength(50), Column(TypeName = "varchar(50)")]
        public string CustomerId { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<OrderImage> OrderImages { get; set; }
        #endregion

    }

    [Table("OrderImages")]
    public class OrderImage
    {
        #region Basic
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, MaxLength(256)]
        public string Src { get; set; }
        #endregion

        #region Relationship

        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }
        [Required, MaxLength(50), Column(TypeName = "varchar(50)")]
        public Guid OrderId { get; set; }
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
        [Required, MaxLength(256)]
        public string ProductName { get; set; }
        [MaxLength(256)]
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
        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }
        [Required, MaxLength(50), Column(TypeName = "varchar(50)")]
        public Guid OrderId { get; set; }
        #endregion
    }
}
