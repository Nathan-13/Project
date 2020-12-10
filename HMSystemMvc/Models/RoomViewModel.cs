using System;
using System.ComponentModel.DataAnnotations;

namespace HMSystemMvc.Models
{
    public class RoomViewModel
    {
        public Guid? RoomId { get; set; }

        [Required]
        public string RoomLocation { get; set; }

        [Required]
        public string IsRoomBooked { get; set; }

        [Required] 
        public char RoomStatus { get; set; }

        [Required] 
        public char RoomIsClean { get; set; }
    }
}
