namespace ReservationSystem_API
{
    public class Facility
    {
        public int Idx { get; set; }
        public String Name { get; set; } = "";
        public String Purpose { get; set; } = "";
        public String Location { get; set; } = "";

        public Facility()
        {
            Idx = -1;
        }
        public Facility(int idx, string name, string purpose, string location)
        {
            Idx = idx;
            Name = name;
            Purpose = purpose;
            Location = location;
        }
    }
}
