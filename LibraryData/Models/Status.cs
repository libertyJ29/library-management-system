using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LibraryData.Models
{
    public class Status
    {
        public int Id { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        public String Description { get; set; }
    }
}
