namespace Backend.Model.DTO
{
    public class WaterLevelSensorDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public string Unit { get; set; }
        public string Location { get; set; }
    }
}
