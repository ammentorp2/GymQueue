namespace GymQueue.Models
{
    public class User
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public short CountryCode { get; set; } = 1;
    }
}
