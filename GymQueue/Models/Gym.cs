using System.Collections.Generic;

namespace GymQueue.Models
{
    public class Gym
    {
        public long Id { get; set; }

        // Unique collection of equipment in the gym
        public HashSet<Equipment> Equipment { get; set; } = new();

        public string ImageUrl => $"gym_{Id}";

        public string Address { get; set; } = string.Empty;
    }
}
