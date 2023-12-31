using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace F1_Balkan_Edition.Infrastrucure.Data.Models
{
    public class Car
    {
        /// <summary>
        /// Identificator of the car
        /// </summary>
        [Key]
        [Comment("Identificator of the car")]
        public int Id { get; set; }

        /// <summary>
        /// The model of the car
        /// </summary>
        [Required]
        [Comment("The model of the car")]
        public string Model { get; set; } = null!;

        /// <summary>
        /// The horsepower of the car
        /// </summary>
        [Required]
        [Comment("The horsepower of the car")]
        public string Power { get; set; } = null!;
    }
}