namespace Backend.Model.Entitys
{
    public class SoilMoistureSensorEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public string Unit { get; set; }
        public string Location { get; set; }
    }
}
