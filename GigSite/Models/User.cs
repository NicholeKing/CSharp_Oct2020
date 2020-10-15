using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GigSite.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}

        [Required]
        [MinLength(2)]
        public string RealName {get;set;}
        
        [Required]
        [MinLength(2)]
        public string UserName {get;set;}
        
        [Required]
        [EmailAddress]
        public string Email {get;set;}
        
        [Required]
        [DataType(DataType.Date)]
        public DateTime DoB {get;set;}
        
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string Password {get;set;}
        
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        //My one to many -> the orders my user has to complete
        public List<Gig> Commissions {get;set;}

        public List<OrderHistory> OrderHistory {get;set;}
        
        [NotMapped]
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string Confirm {get;set;}
    }
}