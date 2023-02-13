using GoZone.BackendServer.Data.Enums;
using GoZone.BackendServer.Data.Interfaces;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoZone.BackendServer.Data.Entities
{
    public class AppUser : IdentityUser, IDateTracking
    {
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public UserStatus Status { get; set; }

        [Required, MaxLength(50)]
        public string FirstName { get; set; }

        [Required, MaxLength(50)]
        public string LastName { get; set; }

        public DateTime? BirthDay { get; set; }

        [MaxLength(256), Column(TypeName = "varchar(256)")]
        public string? Avatar { get; set; }
    }

    public class AppRole : IdentityRole
    {
        [MaxLength(256)]
        public string Description { get; set; }
    }

    [Table("Permissions")]
    public class Permission
    {
        public Permission(string functionId, string roleId, string commandId)
        {
            FunctionId = functionId;
            RoleId = roleId;
            CommandId = commandId;
        }

        [ForeignKey("RoleId")]
        public virtual AppRole AppRole { get; set; }

        [Required, Key, MaxLength(450), Column(Order = 0, TypeName = "nvarchar(450)")]
        public string RoleId { get; set; }

        [ForeignKey("FunctionId")]
        public virtual Function Function { get; set; }

        [Required, Key, MaxLength(50), Column(Order = 1, TypeName = "varchar(50)")]
        public string FunctionId { get; set; }

        [ForeignKey("CommandId")]
        public virtual Command Command { get; set; }

        [Required, Key, MaxLength(50), Column(Order = 2, TypeName = "varchar(50)")]
        public string CommandId { get; set; }
    }

    [Table("Functions")]
    public class Function : ISortable
    {
        public int SortOrder { get; set; }

        [Key, MaxLength(50), Column(TypeName = "varchar(50)")]
        public string Id { get; set; }

        [Required, MaxLength(256)]
        public string Name { get; set; }

        [Required, MaxLength(225)]
        public string Url { get; set; }

        [MaxLength(50), Column(TypeName = "varchar(50)")]
        public string ParentId { get; set; }

        public virtual ICollection<CommandInFunction> CommandInFunctions { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; }
    }

    [Table("Commands")]
    public class Command
    {
        [Key, MaxLength(50), Column(TypeName = "varchar(50)")]
        public string Id { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        public virtual ICollection<CommandInFunction> CommandInFunctions { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; }
    }

    [Table("CommandInFunctions")]
    public class CommandInFunction
    {
        [ForeignKey("CommandId")]
        public virtual Command Command { get; set; }

        [Required, MaxLength(50), Column(Order = 0, TypeName = "varchar(50)")]
        public string CommandId { get; set; }

        [ForeignKey("FunctionId")]
        public virtual Function Function { get; set; }

        [Required, MaxLength(50), Column(Order = 1, TypeName = "varchar(50)")]
        public string FunctionId { get; set; }
    }
}