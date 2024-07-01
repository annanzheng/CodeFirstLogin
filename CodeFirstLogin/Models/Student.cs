using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;


namespace CodeFirstLogin.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required]
        public string UserName { get; set; }

        [EmailAddress]
        [Required]
        public string EmailAddress { get; set; }

        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
        [NotMapped]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        // public HttpPostedFileBase ProfileImage { get; set; }

        // public string ProfileImagePath { get; set; }
    }
}