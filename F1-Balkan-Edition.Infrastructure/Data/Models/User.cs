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

        /// <summary>
        /// Lap time formatted: 00:00:00
        /// </summary>
        [Required]
        [MaxLength(9)]
        [Comment("Lap time formatted: 00:00:00")]
        public string LapTime { get; set; } = null!;

        /// <summary>
        /// Lap time in miliseconds
        /// </summary>
        [Required]
        [Comment("Lap time in miliseconds")]
        public long Miliseconds { get; set; }

        /// <summary>
        /// Property which will be used in the ranking to sort the users
        /// </summary>
        [Required]
        [Comment("Property which will be used in the ranking to sort the users")]
        public int Rank { get; set; }

        /// <summary>
        /// Identificator of the car
        /// </summary>
        [Required]
        [Comment("Identificator of the car")]
        public int CarId { get; set; }

        /// <summary>
        /// The car which the user uses
        /// </summary>
        [Required]
        [Comment("The car which the user uses")]
        [ForeignKey(nameof(CarId))]
        public Car Car { get; set; } = null!;
    }
}
