using System;
using System.Collections.Generic;

namespace GymQueue.Models
{
    public class Party
    {
        public long Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public DateTime CheckInTime { get; set; }

        // Unique collection of users in the party
        public HashSet<User> Users { get; set; } = new();

        public HashSet<Equipment> WaitList { get; } = new();

        public Gym Gym { get; set; } = new();

        public int GetPartySize()
        {
            return Users.Count;
        }

        public void AddToWaitlist(Equipment equipment)
        {
            if (equipment is null)
            {
                return;
            }

            if (!WaitList.Contains(equipment))
            {
                WaitList.Add(equipment);
            }
        }
    }
}
