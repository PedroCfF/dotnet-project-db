using dotnet_project_db.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_project_db.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private AppDBContext _dbContext;

        public MainController(AppDBContext context)
        {
            _dbContext = context;
        }

        [HttpGet(Name = "/vehicles")]
        public List<Vehicle> GetAll()
        {
            return this._dbContext.Vehicles.ToList();
        }
    }
}
