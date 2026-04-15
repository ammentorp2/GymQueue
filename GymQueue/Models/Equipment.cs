using System.Collections.Generic;

namespace GymQueue.Models
{
    public class Equipment
    {
        public long Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public Party? ActiveParty { get; set; }

        public Queue<Party> Queue { get; set; } = new();

        public string ImageUrl => $"equipment_{Id}";
    }
}
