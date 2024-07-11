using controller_action_return_types.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace controller_action_return_types.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public string Employee()
        {
            return "saikumar";
        }
        Employees all = new Employees();
        [Route("get")]
        [HttpGet]
        public Employees AllEmployees()
        {
            all.name = "Test";
            all.id = 1;
      
          
           

            return all;
           
        }
    }
}
