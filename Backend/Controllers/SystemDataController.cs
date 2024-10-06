using Backend.Data;
using Backend.Model.DTO;
using Backend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers
{
    [Route("api/system")]
    [ApiController]
    public class SystemDataController : ControllerBase
    {
        private readonly SystemDataService _systemDataService;
        private readonly ApplicationDbContext _context;


        public SystemDataController(SystemDataService systemDataService, ApplicationDbContext context)
        {
            _systemDataService = systemDataService;
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] SystemDataDto systemDataDto)
        {
            await _systemDataService.SaveSystemData(systemDataDto);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAirHumidity()
        {
            var result = await _context.SystemData
                .OrderByDescending(s => s.Timestamp)  
                .Include(s => s.AirHumiditySensor)
                .Include(s => s.Valves)               // Завантажуємо дані клапанів
                .Include(s => s.Pump)                 // Завантажуємо дані насосу
                .Include(s => s.SoilMoistureSensors)  // Завантажуємо дані датчиків вологості ґрунту
                .Include(s => s.TemperatureSensor)    // Завантажуємо дані датчика температури
                .Include(s => s.WaterLevelSensor)     // Завантажуємо дані датчика рівня води
                .Include(s => s.AirHumiditySensor)    // Завантажуємо дані датчика вологості повітря
                .FirstOrDefaultAsync();

            if (result == null)
            {
                return NotFound("No air humidity data found.");
            }

            return Ok(result);
        }

        //[HttpGet]
        //public async Task<IActionResult> GetTemperature()
        //{
        //    var result = await _context.SystemData
        //        .OrderByDescending(s => s.Timestamp)
        //        .Include(s => s.TemperatureSensor)
        //        .FirstOrDefaultAsync();

        //    if (result == null)
        //    {
        //        return NotFound("No air humidity data found.");
        //    }

        //    return Ok(result);
        //}



    }
}
