using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace F1_Balkan_Edition.Infrastrucure.Data.Models
{
    public class User
    {
        /// <summary>
        /// Identificator of the user
        /// </summary>
        [Key]
        [Comment("Identificator of the user")]
        public int Id { get; set; }

        ///// <summary>
        ///// The name of the racer
        ///// </summary>
        //[Comment("The name of the racer")]
        //public required string Name { get; set; }

        /// <summary>
        /// Lap time formatted: 00:00:00
        /// </summary>
        [MaxLength(9)]
        [Comment("Lap time formatted: 00:00:00")]
        public required string LapTime { get; set; }

        /// <summary>
        /// This is the track where the lap has been set
        /// </summary>
        [MaxLength(100)]
        [Comment("This is the track where the lap has been set")]
        public required string Track { get; set; }

        /// <summary>
        /// Identificator of the car
        /// </summary>
        [Required]
        [Comment("Identificator of the car")]
        public int CarId { get; set; }

        /// <summary>
        /// The car which the user uses
        /// </summary>
        [Comment("The car which the user uses")]
        [ForeignKey(nameof(CarId))]
        public required Car Car { get; set; }
    }
}
