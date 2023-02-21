using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using GoZone.ViewModels.Systems;
using Microsoft.EntityFrameworkCore;
using GoZone.ViewModels;

namespace GoZone.BackendServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        public RolesController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        // URL: POST api/roles
        [HttpPost]
        public async Task<IActionResult> PostRole(RoleVm roleVm)
        {
            var role = new IdentityRole()
            {
                Id = roleVm.Id,
                Name = roleVm.Name,
                NormalizedName = roleVm.Name.ToUpper()
            };
            var result = await _roleManager.CreateAsync(role);
            if (result.Succeeded)
            {
                return CreatedAtAction(nameof(GetById), new
                {
                    id = role.Id
                }, roleVm);
            }
            else
            {
                return BadRequest(result.Errors);
            }
        }

        // URL: GET api/roles
        [HttpGet]
        public async Task<IActionResult> GetRoles()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            var roleVms = roles.Select(m => new RoleVm()
                {
                    Id = m.Id,
                    Name = m.Name
                });
            return Ok(roleVms);
        }

        // URL: GET api/roles/?filter={filter}&page=1&pagesize=10
        [HttpGet]
        public async Task<IActionResult> GetRolesPaging(string filter,int page = 1, int pageSize = 10)
        {
            var query = _roleManager.Roles;
            if(!string.IsNullOrEmpty(filter))
            {
                query = query.Where(m => m.Id.Contains(filter) || m.Name.Contains(filter));
            }
            var totalRecords = await query.CountAsync();
            var items = await query.Skip(page - 1 * pageSize).Take(pageSize)
                .Select(m => new RoleVm()
                {
                    Id = m.Id,
                    Name = m.Name
                })
                .ToListAsync();
            var pagination = new Pagination<RoleVm>
            {
                Items = items,
                TotalRecords = totalRecords
            };
            return Ok(pagination);
        }

        // URL: GET api/roles/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult>  GetById(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
                return NotFound();
            var roleVm = new RoleVm()
            {
                Id = role.Id,
                Name = role.Name
            };
            return Ok(roleVm);
        }

        // URL: PUT api/roles/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRole(string id, [FromBody]RoleVm roleVm)
        {
            if (id != roleVm.Id)
                return BadRequest();
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
                return NotFound();
            role.Name = roleVm.Name;
            role.NormalizedName = roleVm.Name.ToUpper();
            var result = await _roleManager.UpdateAsync(role);
            if (result.Succeeded)
            {
                return NoContent();
            }
            else
            {
                return BadRequest(result.Errors);
            }
        }

        // URL: DELETE api/roles/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRole(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
                return NotFound();
            var result = await _roleManager.DeleteAsync(role);
            if (result.Succeeded)
            {
                var rolevm = new RoleVm()
                {
                    Id = role.Id,
                    Name = role.Name
                };
                return Ok(rolevm);
            }
            else
            {
                return BadRequest(result.Errors);
            }
        }
    }
}
