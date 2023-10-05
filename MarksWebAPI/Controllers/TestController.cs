using MarksWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarksWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet(Name = "GetTesting")]
        public IEnumerable<User> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new User
            {
                Id = index,
                Name = "Testing",
                Email = "admin@testing.com"
            })
            .ToArray();
        }
    }
}
