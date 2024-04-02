using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Auction.Models
{
    public class Players
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }


        [Required]
        [Display(Name = "Role")]
        public string role { get; set; }


        [Required]
        [Display(Name = "Playing Team")]
        public string Team { get; set; }

        [Required]
        [ValidateNever]
        public string ImageUrl { get; set; }
    }
}
