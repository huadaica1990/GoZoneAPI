using GoZone.BackendServer.Data.Enums;
using GoZone.BackendServer.Data.Interfaces;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoZone.BackendServer.Data.Entities
{
    [Table("Products")]
    public class Product : IDateTracking, ISortable, IHasCreate, ISwitchable, IHasSoftDelete
    {
        #region Auto
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int SortOrder { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public Status Status { get; set; }
        public bool IsDeleted { get; set; }
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
        public virtual ICollection<ProductInCategory> ProductInCategories { get; set; }
        public virtual ICollection<ProductTranslate> ProductTranslates { get; set; }
        #endregion
    }

    [Table("ProductTranslates")]
    public class ProductTranslate : IMultiLanguage
    {
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

        [ForeignKey("ProductId")]
        public virtual Product Products { get; set; }
        [Required, Key, Column(Order = 1)]
        public int ProductId { get; set; }
        #endregion
    }

    [Table("ProductCategories")]
    public class ProductCategory : IDateTracking, ISortable, INoDelete
    {
        #region Auto
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int SortOrder { get; set; }
        public bool NoDeleted { get; set; }
        #endregion

        #region Basic
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        #endregion

        #region Relationship
        public virtual ICollection<ProductCategory> ChildCategories { get; set; }

        [ForeignKey("ParentId")]
        public virtual ProductCategory ParentCategory { get; set; }
        public int? ParentId { get; set; }

        public virtual ICollection<ProductInCategory> ProductInCategories { get; set; }
        public virtual ICollection<ProductCategoryTranslate> ProductCategoryTranslates { get; set; }
        #endregion
    }

    [Table("ProductCategoryTranslates")]
    public class ProductCategoryTranslate : IMultiLanguage
    {
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

        [ForeignKey("ProductCategoryId")]
        public virtual ProductCategory ProductCategories { get; set; }
        [Required, Key, Column(Order = 1)]
        public int ProductCategoryId { get; set; }
        #endregion
    }

    [Table("ProductInCategories")]
    public class ProductInCategory
    {
        #region Basic
        public bool IsDefault { get; set; }
        #endregion

        #region Relationship
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        [Key, Column(Order = 0)]
        public int ProductId { get; set; }

        [ForeignKey("ProductCategoryId")]
        public virtual ProductCategory ProductCategory { get; set; }
        [Key, Column(Order = 1)]
        public int ProductCategoryId { get; set; }
        #endregion
    }
}
