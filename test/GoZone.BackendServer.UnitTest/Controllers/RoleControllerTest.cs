using GoZone.BackendServer.Controllers;
using GoZone.ViewModels;
using GoZone.ViewModels.Systems;
using KnowledgeSpace.BackendServer.UnitTest.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace GoZone.BackendServer.UnitTest.Controllers
{
    public class RoleControllerTest
    {
        private readonly Mock<RoleManager<IdentityRole>> _mockRoleManager;
        private List<IdentityRole>  _roleSources = new List<IdentityRole>() {
            new IdentityRole("test1"),
            new IdentityRole("test2"),
            new IdentityRole("test3"),
            new IdentityRole("test4")
        };
        public RoleControllerTest() {
            var roleStore = new Mock<IRoleStore<IdentityRole>>();
            _mockRoleManager = new Mock<RoleManager<IdentityRole>>(roleStore.Object, null, null, null, null);
        }

        [Fact]
        public void ShoudCreateInstance_NotNull_Success()
        {
            var rolesController = new RolesController(_mockRoleManager.Object);
            Assert.NotNull(rolesController);
        }

        [Fact]
        public async Task PostRole_ValidInput_Success()
        {
            _mockRoleManager.Setup(m => m.CreateAsync(It.IsAny<IdentityRole>()))
                .ReturnsAsync(IdentityResult.Success);
            var rolesController = new RolesController(_mockRoleManager.Object);
            var result = await rolesController.PostRole(new ViewModels.Systems.RoleVm()
            {
                Id = "test",
                Name = "Test"
            });

            Assert.NotNull(result);
            Assert.IsType<CreatedAtActionResult>(result);
        }

        [Fact]
        public async Task PostRole_ValidInput_Failed()
        {
            _mockRoleManager.Setup(m => m.CreateAsync(It.IsAny<IdentityRole>()))
                .ReturnsAsync(IdentityResult.Failed(new IdentityError[] {}));
            var rolesController = new RolesController(_mockRoleManager.Object);
            var result = await rolesController.PostRole(new ViewModels.Systems.RoleVm()
            {
                Id = "test",
                Name = "Test"
            });

            Assert.NotNull(result);
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async Task GetRoles_HasData_ReturnSuccess()
        {
            var roles = _roleSources.AsAsyncQueryable();
            _mockRoleManager.Setup(m => m.Roles)
                .Returns(roles);
            var rolesController = new RolesController(_mockRoleManager.Object);
            var result = await rolesController.GetRoles();
            var okResult = result as OkObjectResult;
            var roleVms = okResult.Value as IEnumerable<RoleVm>;
            Assert.True(roleVms.Count() > 0);
        }
        
        [Fact]
        public async Task GetRoles_ThrowException_Failed()
        {
            _mockRoleManager.Setup(m => m.Roles).Throws<Exception>();
            var rolesController = new RolesController(_mockRoleManager.Object);

            await Assert.ThrowsAnyAsync<Exception>(async ()=> await rolesController.GetRoles());
        }


        [Fact]
        public async Task GetRolesPaging_NoFillter_ReturnSuccess()
        {
            var roles = _roleSources.AsAsyncQueryable();
            _mockRoleManager.Setup(m => m.Roles)
                .Returns(roles);
            var rolesController = new RolesController(_mockRoleManager.Object);
            var result = await rolesController.GetRolesPaging(null,1,2);
            var okResult = result as OkObjectResult;
            var roleVms = okResult.Value as Pagination<RoleVm>;
            Assert.Equal(4, roleVms.TotalRecords);
            Assert.Equal(2, roleVms.Items.Count);
        }

        [Fact]
        public async Task GetRolesPaging_HasFillter_ReturnSuccess()
        {
            var roles = _roleSources.AsAsyncQueryable();
            _mockRoleManager.Setup(m => m.Roles)
                .Returns(roles);
            var rolesController = new RolesController(_mockRoleManager.Object);
            var result = await rolesController.GetRolesPaging("test3", 1, 2);
            var okResult = result as OkObjectResult;
            var roleVms = okResult.Value as Pagination<RoleVm>;
            Assert.Equal(1, roleVms.TotalRecords);
            Assert.Equal(1, roleVms.Items.Count);
        }
        [Fact]
        public async Task GetRolesPaging_ThrowException_Failed()
        {
            _mockRoleManager.Setup(m => m.Roles).Throws<Exception>();
            var rolesController = new RolesController(_mockRoleManager.Object);
            await Assert.ThrowsAnyAsync<Exception>(async () => await rolesController.GetRolesPaging(null,1,2));
        }

        [Fact]
        public async Task GetById_HasData_ReturnSuccess()
        {
            var roles = _roleSources.AsAsyncQueryable();
            _mockRoleManager.Setup( m => m.FindByIdAsync(It.IsAny<string>()))
                .ReturnsAsync(new IdentityRole()
                {
                    Id = "test1",
                    Name = "test1"
                });
            var rolesController = new RolesController(_mockRoleManager.Object);
            var result = await rolesController.GetById("test1");
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult);
            var roleVms = okResult.Value as RoleVm;
            Assert.Equal("test1", roleVms.Name);
        }
        [Fact]
        public async Task GetById_ThrowException_Failed()
        {
            _mockRoleManager.Setup(m => m.FindByIdAsync(It.IsAny<string>())).Throws<Exception>();
            var rolesController = new RolesController(_mockRoleManager.Object);
            await Assert.ThrowsAnyAsync<Exception>(async () => await rolesController.GetById("test1"));
        }

        [Fact]
        public async Task PutRole_ValidInput_Success()
        {
            _mockRoleManager.Setup(m => m.FindByIdAsync(It.IsAny<string>()))
                .ReturnsAsync(new IdentityRole()
                {
                    Id = "test",
                    Name = "test"
                });
            _mockRoleManager.Setup(m => m.UpdateAsync(It.IsAny<IdentityRole>()))
                .ReturnsAsync(IdentityResult.Success);
            var rolesController = new RolesController(_mockRoleManager.Object);
            var result = await rolesController.PutRole("test", new RoleVm()
            {
                Id= "test",
                Name= "test",
            });
            Assert.NotNull(result);
            Assert.IsType<NoContentResult>(result);
        }

        [Fact]
        public async Task PutRole_ValidInput_Failed()
        {
            _mockRoleManager.Setup(m => m.FindByIdAsync(It.IsAny<string>()))
                .ReturnsAsync(new IdentityRole()
                {
                    Id = "test",
                    Name = "test"
                });
            _mockRoleManager.Setup(m => m.UpdateAsync(It.IsAny<IdentityRole>()))
                .ReturnsAsync(IdentityResult.Failed(new IdentityError[] { }));
            var rolesController = new RolesController(_mockRoleManager.Object);
            var result = await rolesController.PutRole("test", new RoleVm()
            {
                Id = "test",
                Name = "test",
            });
            Assert.NotNull(result);
            Assert.IsType<BadRequestObjectResult>(result);
        }



        [Fact]
        public async Task DeleteRole_ValidInput_Success()
        {
            _mockRoleManager.Setup(m => m.FindByIdAsync(It.IsAny<string>()))
                .ReturnsAsync(new IdentityRole()
                {
                    Id = "test",
                    Name = "test"
                });
            _mockRoleManager.Setup(m => m.DeleteAsync(It.IsAny<IdentityRole>()))
                .ReturnsAsync(IdentityResult.Success);
            var rolesController = new RolesController(_mockRoleManager.Object);
            var result = await rolesController.DeleteRole("test");
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async Task DeleteRole_ValidInput_Failed()
        {
            _mockRoleManager.Setup(m => m.FindByIdAsync(It.IsAny<string>()))
                .ReturnsAsync(new IdentityRole()
                {
                    Id = "test",
                    Name = "test"
                });
            _mockRoleManager.Setup(m => m.DeleteAsync(It.IsAny<IdentityRole>()))
                .ReturnsAsync(IdentityResult.Failed(new IdentityError[] { }));
            var rolesController = new RolesController(_mockRoleManager.Object);
            var result = await rolesController.DeleteRole("test");
            Assert.IsType<BadRequestObjectResult>(result);
        }


    }
}
