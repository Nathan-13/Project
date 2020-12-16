using System;

namespace HMSystem.Models
{
    public class Room
    {
        public Room(string roomLocation, char roomStatus, char roomIsClean) {
            RoomId = Guid.NewGuid();
            RoomLocation = roomLocation;
            RoomStatus = roomStatus;
            RoomIsClean = roomIsClean;
            IsRoomBooked = false;

        }
        // Data members
        public Guid RoomId { get; set; }
        public string RoomLocation { get; set; }
        public bool IsRoomBooked { get; set; }
        public char RoomStatus { get; set; } // E - room empty, O - room occupied with patient.
        public char RoomIsClean { get; set; } // Y - yes room is clean, and N - room is not clean.

        public void Book() {
            if (IsRoomBooked) {
                throw new Exception("This room is already assigned to a patient!");
            }
            if (RoomStatus == 'O' && RoomIsClean == 'N') {
                throw new Exception("Cannot assign this room yet");
            }
            IsRoomBooked = true;
            Console.WriteLine($"Room - {RoomId} in the {RoomLocation} is assigned!");
        }

        public override string ToString() {
            string details = "";
            details += $"Room number: {RoomId}\n";
            details += $"Location: {RoomLocation}";
            return details + "\n";
        }
    }
}