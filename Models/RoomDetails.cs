﻿using System.ComponentModel.DataAnnotations;

namespace Hotels.Models
{
    public class RoomDetails
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Image1 { get; set; }

        [Required]
        [StringLength(50)]
        public string Image2 { get; set; }

        [Required]
        [StringLength(50)]
        public string Image3 { get; set; }

        [Required]
        [StringLength(50)]
        public string Futures { get; set; }

       
        [StringLength(50)]
        public string? Food { get; set; }

        [Required]
        public int IdRooms { get; set; }

        [Required]
        public int IdHotel { get; set; }
    }
}
