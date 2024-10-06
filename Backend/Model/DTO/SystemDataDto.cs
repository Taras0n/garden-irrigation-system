namespace Backend.Model.DTO
{
    public class SystemDataDto
    {
        public DateTime Timestamp { get; set; }
        public ICollection<ValveDto> Valves { get; set; }
        public PumpDto Pump { get; set; }
        public ICollection<SoilMoistureSensorDto> SoilMoistureSensors { get; set; }
        public TemperatureSensorDto TemperatureSensor { get; set; }
        public WaterLevelSensorDto WaterLevelSensor { get; set; }
        public AirHumiditySensorDto AirHumiditySensor { get; set; }
    }
}
