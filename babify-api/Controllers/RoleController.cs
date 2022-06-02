using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using babify_api.Models.Authentication;


namespace babify_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {

        readonly RoleManager<UserRole> _roleManager;
        public RoleController(RoleManager<UserRole> roleManager)
        {
            _roleManager = roleManager;
        }


    }
}
