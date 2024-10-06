using Backend.Data;
using Backend.Model.Entitys;
using Microsoft.EntityFrameworkCore;
using System;

namespace Backend.Repositories.SystemData
{
    public class SystemDataRepository : ISystemDataRepository
    {
        private readonly ApplicationDbContext _context;

        public SystemDataRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddSystemDataAsync(SystemDataEntity systemData)
        {
            _context.SystemData.Add(systemData);
            await _context.SaveChangesAsync();
        }

        public async Task<List<SystemDataEntity>> GetAllSystemDataAsync()
        {
            return await _context.SystemData
                                 .Include(sd => sd.Valves)
                                 .Include(sd => sd.Pump)
                                 .Include(sd => sd.SoilMoistureSensors)
                                 .Include(sd => sd.TemperatureSensor)
                                 .Include(sd => sd.WaterLevelSensor)
                                 .Include(sd => sd.AirHumiditySensor)
                                 .ToListAsync();
        }
    }
}
