using System;

namespace HMSystem.Storage.EFModels
{
    public class Room
    {
        public Guid RoomId { get; set; }
        public string RoomLocation { get; set; }
        public bool IsRoomBooked { get; set; }
        public char RoomStatus { get; set; } // E - room empty, O - room occupied with patient.
        public char RoomIsClean { get; set; } // Y - yes room is clean, and N - room is not clean.

    }
}