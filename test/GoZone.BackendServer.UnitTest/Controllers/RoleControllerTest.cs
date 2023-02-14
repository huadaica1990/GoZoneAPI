using GoZone.BackendServer.Controllers;
using GoZone.ViewModels.Systems;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoZone.BackendServer.UnitTest.Controllers
{
    public class RoleControllerTest
    {
        private readonly Mock<RoleManager<IdentityRole>> _mockRoleManager;
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
        public async Task PostRole_ValidInput_Fail()
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
        public async Task GetRole_ValidInput_Success()
        {
            _mockRoleManager.Setup(m => m.Roles)
                .Returns(new List<IdentityRole>()
                {
                    new IdentityRole("test1"),
                    new IdentityRole("test2")
                }.AsQueryable());
            var rolesController = new RolesController(_mockRoleManager.Object);
            var result = await rolesController.GetRoles();
            var okResult = result as OkObjectResult;
            Assert.True((okResult.Value as List<RoleVm>).Count > 0);
        }
        [Fact]
        public async Task GetRole_ValidInput_Fail()
        {
            _mockRoleManager.Setup(m => m.Roles).Throws<Exception>();
            var rolesController = new RolesController(_mockRoleManager.Object);
            var result = await rolesController.GetRoles();

            await Assert.ThrowsAny<Exception>(async ()=> await rolesController.GetRoles());
        }


    }
}
