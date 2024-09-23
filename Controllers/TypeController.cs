using Microsoft.AspNetCore.Mvc;
using ToneForum.Repository.Interfaces;

namespace ToneForum.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TypeController : ControllerBase
    {
        private readonly ITypeRepository repo;

        public TypeController(ITypeRepository repo)
        {
            this.repo = repo;
        }

        // Create: 

        //##############################################################################################################

        // Read:

        [HttpGet("GetAllTypes")] // Get all types
        public async Task<IActionResult> GetAllTypes()
        {
            var allTypes = await repo.GetAllTypes();

            return Ok(allTypes);
        }

        //##############################################################################################################

        // Update: 

        //##############################################################################################################

        // Delete: 
    }
}
