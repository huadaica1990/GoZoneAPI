using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using GoZone.BackendServer.Data.Interfaces;
using GoZone.BackendServer.Data.Enums;
using System.ComponentModel;

namespace GoZone.BackendServer.Data.Entities
{
    public class AppUser : IdentityUser, IDateTracking
    {
        #region Auto
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public Status Status { get; set; }
        #endregion

        #region Basic
        [Required, MaxLength(50)]
        public string FirstName { get; set; }
        [Required, MaxLength(50)]
        public string LastName { get; set; }
        public DateTime? BirthDay { get; set; }
        [MaxLength(255), Column(TypeName = "varchar(255)")]
        public string? Avatar { get; set; }
        #endregion
    }
    public class AppRole : IdentityRole
    {
        #region Basic
        [MaxLength(255)]
        public string Description { get; set; }
        #endregion
    }

    [Table("Permissions")]
    public class Permission
    {
        #region Basic
        public Permission(string functionId, string roleId, string commandId)
        {
            FunctionId = functionId;
            RoleId = roleId;
            CommandId = commandId;
        }
        #endregion

        #region Relationship
        [Required, MaxLength(50), Column(TypeName = "varchar(50)")]
        public string FunctionId { get; set; }
        [Required, MaxLength(50), Column(TypeName = "varchar(50)")]
        public string RoleId { get; set; }
        [Required, MaxLength(50), Column(TypeName = "varchar(50)")]
        public string CommandId { get; set; }
        #endregion
    }
    [Table("Functions")]
    public class Function : ISortable
    {
        #region Auto
        public int SortOrder { get; set; }
        #endregion

        #region Basic
        [Key, MaxLength(50), Column(TypeName = "varchar(50)")]
        public string Id { get; set; }
        [Required, MaxLength(255)]
        public string Name { get; set; }
        [Required, MaxLength(225)]
        public string Url { get; set; }
        [MaxLength(50), Column(TypeName = "varchar(50)")]
        public string ParentId { get; set; }
        #endregion
    }

    [Table("Commands")]
    public class Command
    {
        #region Basic
        [Key, MaxLength(50), Column(TypeName = "varchar(50)")]
        public string Id { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }
        #endregion
    }
    [Table("CommandInFunctions")]
    public class CommandInFunction
    {
        #region Relationship
        [Required, MaxLength(50), Column(TypeName = "varchar(50)")]
        public string CommandId { get; set; }
        [Required, MaxLength(50), Column(TypeName = "varchar(50)")]
        public string FunctionId { get; set; }
        #endregion
    }
}
