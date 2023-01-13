using Microsoft.AspNetCore.Mvc;
using OrganicLivingApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrganicLivingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly ILogger<ImagesController> _logger;

        public ImagesController(ILogger<ImagesController> logger)
        {
            _logger = logger;
        }

        // GET: api/Images
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/Images/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/Images/Upload
        [HttpPost("Upload")]
        public async Task<string> Post([FromBody] UploadImageInput value)
        {
            if (value != null && !string.IsNullOrWhiteSpace(value.Image))
            {
                _logger.LogInformation("Received Image.");
                return "Received Image";
            }

            return "No Image Received";
        }

        // PUT api/Images/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/Images/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
