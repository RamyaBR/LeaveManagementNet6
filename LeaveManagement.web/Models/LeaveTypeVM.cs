﻿using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.web.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Display(Name = "Leave Type Name")]
        [Required]
        public string Name { get; set; }

        [Display(Name= "Default Number of Days")]
        [Required]
        [Range(1,25, ErrorMessage ="Please Enter A Valid Number")]
        public int DefaultDays { get; set; }
    }
}
