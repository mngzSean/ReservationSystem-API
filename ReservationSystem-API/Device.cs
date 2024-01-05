namespace ReservationSystem_API
{
    public class Device
    {
        public int Idx {  get; set; }
        public String Pid { get; set; } = "";
        public String Label { get; set; } = "";
        public String Type { get; set; } = "";
        public String Name { get; set; } = "";
        public String Sn { get; set; } = "";

        public Company Company { get; set; } = new Company();
        public Facility Facility { get; set; } = new Facility();
    }
}
