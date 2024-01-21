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
        /// The brand of the car
        /// </summary>
        [MaxLength(20)]
        [Comment("The brand of the car")]
        public required string CarBrand { get; set; }

        /// <summary>
        /// The model of the car
        /// </summary>
        [Comment("The model of the car")]
        public required string Model { get; set; }

        /// <summary>
        /// The horsepower of the car
        /// </summary>
        [Comment("The horsepower of the car")]
        public required string Power { get; set; }
    }
}