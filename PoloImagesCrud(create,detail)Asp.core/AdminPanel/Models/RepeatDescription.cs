using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Models
{
    public class RepeatDescription
    {
        public int Id { get; set; }
        [Required,StringLength(150)]
        public string Title { get; set; }
        [Required,StringLength(500)]
        public string Description { get; set; }

    }
}
