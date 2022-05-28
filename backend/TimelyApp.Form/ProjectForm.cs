﻿using System.ComponentModel.DataAnnotations;

namespace TimelyApp.Form
{
    public class ProjectForm
    {
        [Required]
        public string? Name { get; set; }

        [Required]
        public string? StartTime { get; set; }

        [Required]        
        public string? EndTime { get; set; }
    }
}
