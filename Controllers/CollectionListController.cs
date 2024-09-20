using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using ToneForum.Repository.Interfaces;
using ToneForum.Repository.Models;

namespace ToneForum.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CollectionListController : ControllerBase
    {
        private readonly ICollectionListRepository repo;

        public CollectionListController(ICollectionListRepository repo)
        {
            this.repo = repo;
        }

        // Create: 

        //##############################################################################################################

        // Read:

        //##############################################################################################################

        // Update: 

        //##############################################################################################################

        // Delete: 
    }
}
