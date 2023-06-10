using System.ComponentModel.DataAnnotations;
namespace HUMG.Models;

    public class H38
    {
        [Key]
         [Display( Name = "MÃ H38")]
        public string? H38ID{get; set;}
       [Display( Name = "TÊN H38")]
        public string? H38Name {get; set;}
       
    }
