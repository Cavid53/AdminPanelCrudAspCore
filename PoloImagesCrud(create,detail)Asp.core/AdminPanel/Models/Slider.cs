using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This input is empty"), StringLength(100,ErrorMessage = "Simbols are few than more")]
        public string Title { get; set; }
        [Required(ErrorMessage = "This input is empty"), StringLength(500,ErrorMessage = "Simbols are few than more")]
        public string Description { get; set; }
        [Required, StringLength(250)]
        public string Image { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "This input is empty")]
        public IFormFile Photo { get; set; }
    }
}
