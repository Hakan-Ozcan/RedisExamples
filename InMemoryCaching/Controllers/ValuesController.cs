using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace InMemoryCaching.Controllers
{
  
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        readonly IMemoryCache _memoryCache;
        public ValuesController(IMemoryCache memoryCache)
        {
            _memoryCache=memoryCache; 
        }
        [HttpGet("set/{name}")]
        public void Set(string name) 
        {
            _memoryCache.Set("name", name);
        }
        [HttpGet]
        public string Get()
        {
            if (_memoryCache.TryGetValue<string>("name",out string hakan))
            {
                return hakan.Substring(3);
            }
            return "";
        }

    }
}