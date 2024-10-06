namespace Backend.Model.Entitys
{
    public class SystemDataEntity
    {
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }

        public ICollection<ValveEntity> Valves { get; set; }
        public PumpEntity Pump { get; set; }
        public ICollection<SoilMoistureSensorEntity> SoilMoistureSensors { get; set; }
        public TemperatureSensorEntity TemperatureSensor { get; set; }
        public WaterLevelSensorEntity WaterLevelSensor { get; set; }
        public AirHumiditySensorEntity AirHumiditySensor { get; set; }
    }
}
