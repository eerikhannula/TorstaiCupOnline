using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using TorstaiCupAC.Data;
using TorstaiCupAC.Models;

namespace TorstaiCupAC.Controllers
{
    [Route("api/drivers")]
    [ApiController]
    public class DriverController : Controller
    {

        private readonly IDbContextFactory<TorstaiCupContext> _contextFactory;

        public DriverController(IDbContextFactory<TorstaiCupContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        [HttpGet]
        public IActionResult GetDrivers()
        {
            using (var context = _contextFactory.CreateDbContext())
            {
                List<Driver> drivers= context.Drivers.ToList();
                return Ok(drivers);

            }
        }
    }
}
