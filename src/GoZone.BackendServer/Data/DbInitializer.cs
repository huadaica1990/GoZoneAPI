using GoZone.BackendServer.Data.Entities;
using GoZone.BackendServer.Data.Enums;
using Microsoft.AspNetCore.Identity;

namespace GoZone.BackendServer.Data
{
    public class DbInitializer
    {

        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public DbInitializer(
            ApplicationDbContext context,
            UserManager<AppUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task Seed()
        {
            #region Quyền
                if (!_roleManager.Roles.Any())
                {
                    await _roleManager.CreateAsync(new IdentityRole
                    {
                        Id = "GoZoneAdmin",
                        Name = "GoZoneAdmin",
                        NormalizedName = "GOZONEADMIN",
                    });
                    await _roleManager.CreateAsync(new IdentityRole
                    {
                        Id = "Admin",
                        Name = "Admin",
                        NormalizedName = "ADMIN",
                    });
                    await _roleManager.CreateAsync(new IdentityRole
                    {
                        Id = "Staff",
                        Name = "Staff",
                        NormalizedName = "STAFF",
                    });
                    await _roleManager.CreateAsync(new IdentityRole
                    {
                        Id = "Customer",
                        Name = "Customer",
                        NormalizedName = "CUSTOMER",
                    });
                }
            #endregion Quyền

            #region Người dùng
                if (!_userManager.Users.Any())
                {
                    var result = await _userManager.CreateAsync(new AppUser
                    {
                        Id = Guid.NewGuid().ToString(),
                        UserName = "gozoneadmin",
                        FirstName = "GoZone",
                        LastName = "Admin",
                        Email = "tronghuy2208@gmail.com",
                        LockoutEnabled = false,
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Now,
                        Status = UserStatus.Active
                    }, "GOZOne!990");
                    if (result.Succeeded)
                    {
                        var user = await _userManager.FindByNameAsync("gozoneadmin");
                        await _userManager.AddToRoleAsync(user, "GoZoneAdmin");
                    }
                    var result1 = await _userManager.CreateAsync(new AppUser
                    {
                        Id = Guid.NewGuid().ToString(),
                        UserName = "admin",
                        FirstName = "Quản trị",
                        LastName = "1",
                        Email = "admin@gmail.com",
                        LockoutEnabled = false
                    }, "@dmIn2022");
                    if (result1.Succeeded)
                    {
                        var user = await _userManager.FindByNameAsync("admin");
                        await _userManager.AddToRoleAsync(user, "Admin");
                    }
                }
            #endregion Người dùng

            #region Chức năng
                if (!_context.Functions.Any())
                {
                    _context.Functions.AddRange(new List<Function>
                    {
                        new Function {Id = "DASHBOARD", Name = "Thống kê", ParentId = null, SortOrder = 1,Url = "/dashboard"  },

                        new Function {Id = "CONTENT",Name = "Nội dung",ParentId = null,Url = "/content" },

                        new Function {Id = "CONTENT_CATEGORY",Name = "Danh mục",ParentId ="CONTENT",Url = "/content/category"  },
                        new Function {Id = "CONTENT_KNOWLEDGEBASE",Name = "Bài viết",ParentId = "CONTENT",SortOrder = 2,Url = "/content/kb" },
                        new Function {Id = "CONTENT_COMMENT",Name = "Trang",ParentId = "CONTENT",SortOrder = 3,Url = "/content/comment" },
                        new Function {Id = "CONTENT_REPORT",Name = "Báo xấu",ParentId = "CONTENT",SortOrder = 3,Url = "/content/report" },

                        new Function {Id = "STATISTIC",Name = "Thống kê", ParentId = null, Url = "/statistic" },

                        new Function {Id = "STATISTIC_MONTHLY_NEWMEMBER",Name = "Đăng ký từng tháng",ParentId = "STATISTIC",SortOrder = 1,Url = "/statistic/monthly-register"},
                        new Function {Id = "STATISTIC_MONTHLY_NEWKB",Name = "Bài đăng hàng tháng",ParentId = "STATISTIC",SortOrder = 2,Url = "/statistic/monthly-newkb"},
                        new Function {Id = "STATISTIC_MONTHLY_COMMENT",Name = "Comment theo tháng",ParentId = "STATISTIC",SortOrder = 3,Url = "/statistic/monthly-comment" },

                        new Function {Id = "SYSTEM", Name = "Hệ thống", ParentId = null, Url = "/system" },

                        new Function {Id = "SYSTEM_USER", Name = "Người dùng",ParentId = "SYSTEM",Url = "/system/user"},
                        new Function {Id = "SYSTEM_ROLE", Name = "Nhóm quyền",ParentId = "SYSTEM",Url = "/system/role"},
                        new Function {Id = "SYSTEM_FUNCTION", Name = "Chức năng",ParentId = "SYSTEM",Url = "/system/function"},
                        new Function {Id = "SYSTEM_PERMISSION", Name = "Quyền hạn",ParentId = "SYSTEM",Url = "/system/permission"},
                    });
                    await _context.SaveChangesAsync();
                }

                if (!_context.Commands.Any())
                {
                    _context.Commands.AddRange(new List<Command>()
                    {
                        new Command(){Id = "VIEW", Name = "Xem"},
                        new Command(){Id = "CREATE", Name = "Thêm"},
                        new Command(){Id = "UPDATE", Name = "Sửa"},
                        new Command(){Id = "DELETE", Name = "Xoá"},
                        new Command(){Id = "APPROVE", Name = "Duyệt"},
                    });
                }
            #endregion Chức năng

            var functions = _context.Functions;
            if (!_context.CommandInFunctions.Any())
            {
                foreach (var function in functions)
                {
                    var createAction = new CommandInFunction()
                    {
                        CommandId = "CREATE",
                        FunctionId = function.Id
                    };
                    _context.CommandInFunctions.Add(createAction);

                    var updateAction = new CommandInFunction()
                    {
                        CommandId = "UPDATE",
                        FunctionId = function.Id
                    };
                    _context.CommandInFunctions.Add(updateAction);
                    var deleteAction = new CommandInFunction()
                    {
                        CommandId = "DELETE",
                        FunctionId = function.Id
                    };
                    _context.CommandInFunctions.Add(deleteAction);

                    var viewAction = new CommandInFunction()
                    {
                        CommandId = "VIEW",
                        FunctionId = function.Id
                    };
                    _context.CommandInFunctions.Add(viewAction);
                }
            }

            if (!_context.Permissions.Any())
            {
                var adminRole = await _roleManager.FindByNameAsync("GoZoneAdmin");
                foreach (var function in functions)
                {
                    _context.Permissions.Add(new Permission(function.Id, adminRole.Id, "CREATE"));
                    _context.Permissions.Add(new Permission(function.Id, adminRole.Id, "UPDATE"));
                    _context.Permissions.Add(new Permission(function.Id, adminRole.Id, "DELETE"));
                    _context.Permissions.Add(new Permission(function.Id, adminRole.Id, "VIEW"));
                }

                var adminRole1 = await _roleManager.FindByNameAsync("Admin");
                foreach (var function in functions)
                {
                    _context.Permissions.Add(new Permission(function.Id, adminRole1.Id, "CREATE"));
                    _context.Permissions.Add(new Permission(function.Id, adminRole1.Id, "UPDATE"));
                    _context.Permissions.Add(new Permission(function.Id, adminRole1.Id, "DELETE"));
                    _context.Permissions.Add(new Permission(function.Id, adminRole1.Id, "VIEW"));
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}
