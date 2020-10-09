using System;
using System.ComponentModel.DataAnnotations;

namespace DatabaseLecture.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}
        [Required]
        public string Name {get;set;}
        [Required]
        public string Email {get;set;}
        [Required]
        public int Age {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

    }
}