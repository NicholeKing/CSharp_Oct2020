using System;
using System.ComponentModel.DataAnnotations;

namespace DatabaseLecture.Models
{
    public class Broken
    {
        [Key]
        public int UserId {get;set;}
        public string Name {get;set;}
        public string Email {get;set;}
        public int Age {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

    }
}