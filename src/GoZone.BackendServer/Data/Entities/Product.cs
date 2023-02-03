using GoZone.BackendServer.Data.Enums;
using GoZone.BackendServer.Data.Interfaces;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoZone.BackendServer.Data.Entities
{
    [Table("Products")]
    public class Product : IDateTracking, ISortable, IHasCreate, ISwitchable
    {
        #region Auto
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int SortOrder { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public Status Status { get; set; }
        #endregion

        #region Basic
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, DefaultValue(0)]
        public decimal Price { get; set; }
        [Required, DefaultValue(0)]
        public decimal PriceFee { get; set; }
        [Required, DefaultValue(0)]
        public decimal PriceTax { get; set; }
        #endregion

        #region Relationship
        #endregion
    }

    [Table("ProductTranslates")]
    public class ProductTranslate : IMultiLanguage
    {
        #region Basic
        [Required, MaxLength(255)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        #endregion

        #region Relationship
        [Required, Range(1, Double.PositiveInfinity)]
        public string LanguageId { get; set; }
        [Required, Range(1, Double.PositiveInfinity)]
        public int ProductId { get; set; }
        #endregion
    }

    [Table("ProductCategories")]
    public class ProductCategory : IDateTracking, ISortable
    {
        #region Auto
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int SortOrder { get; set; }
        #endregion

        #region Basic
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        #endregion

        #region Relationship
        public int? ParentId { get; set; }
        #endregion
    }
    
    [Table("ProductCategoryTranslates")]
    public class ProductCategoryTranslate : IMultiLanguage
    {
        #region Basic
        [Required, MaxLength(255)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        #endregion

        #region Relationship
        [Required, Range(1, Double.PositiveInfinity)]
        public string LanguageId { get; set; }
        [Required, Range(1, Double.PositiveInfinity)]
        public int ProductCategoryId { get; set; }
        #endregion
    }

    [Table("ProductInCategories")]
    public class ProductInCategory
    {
        #region Relationship
        [Required, Range(1, Double.PositiveInfinity)]
        public int ProductId { get; set; }
        [Required, Range(1, Double.PositiveInfinity)]
        public int ProductCategoryId { get; set; }
        #endregion
    }
}
