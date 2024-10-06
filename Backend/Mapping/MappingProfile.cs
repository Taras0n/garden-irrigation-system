using AutoMapper;
using Backend.Model.DTO;
using Backend.Model.Entitys;

namespace Backend.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<SystemDataDto, SystemDataEntity>();
            CreateMap<ValveDto, ValveEntity>();
            CreateMap<PumpDto, PumpEntity>();
            CreateMap<SoilMoistureSensorDto, SoilMoistureSensorEntity>();
            CreateMap<TemperatureSensorDto, TemperatureSensorEntity>();
            CreateMap<WaterLevelSensorDto, WaterLevelSensorEntity>();
            CreateMap<AirHumiditySensorDto, AirHumiditySensorEntity>();
        }
    }
}
