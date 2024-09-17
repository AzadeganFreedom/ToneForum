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
    }
}
