using Microsoft.AspNetCore.Mvc;

namespace HostedAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImageController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            string response = "Vinay";
            return Ok(response);
        }

        [HttpPost]
        public IActionResult Validate(string userName,string Password)
        {
            bool isvalidate = false;
            if(userName == "vinay" && Password == "vinnu")
                isvalidate = true;
            else if (userName == "vamsi" && Password == "vamsi")
                isvalidate= true;
            else
                isvalidate = false;
            return Ok(isvalidate);
        }
    }
}
