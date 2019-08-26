using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Models
{
    public class Service
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="This input is empty"),StringLength(100,ErrorMessage = "Simbols are few than more")]
        public string Title { get; set; }
        [Required(ErrorMessage ="This input is empty"),StringLength(500,ErrorMessage = "Simbols are few than more")]
        public string Description { get; set; }
        [Required(ErrorMessage = "This input is empty"), StringLength(255, ErrorMessage = "Simbols are few than more")]
        public string IconField { get; set; }
    }
}
