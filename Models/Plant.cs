using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace plantDemo.Models
{
     public class Plant
     {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int plantID { get; set; }
        
        [Display(Name = "Enter Plant Name")]
        [Required(ErrorMessage = "{0} Is Required.")]
        public string? PlantName { get; set; }

        [Display(Name = "Enter Water Frequency")]
        [Required(ErrorMessage = "{0} Is Required.")]
        public string? WaterFrequency { get; set; }

        [Display(Name = "Enter Fertilizer Frequency")]
        public string? FertFreq { get; set; }

        [Display(Name = "This Plant is Pet Safe?")]
        public Boolean petSafe { get; set; }

        [Display(Name = "Upload Plant Photo")]
        public string? PlantPhoto { get; set; }
     }
}