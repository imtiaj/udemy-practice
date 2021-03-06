﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;
using System.Text;

namespace DLL.Models
{
    public class EmployeeInfo
    {
        [Key]
        public int EmployeeID { get; set; }
        
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        
        public string DateOfBirth { get; set; }

        
        public string Gender { get; set; }

        [Required]
        [StringLength(100)]
        public string NationalID { get; set; }

        [Required]
        [StringLength(30)]
        public string Email { get; set; }
    }
}
