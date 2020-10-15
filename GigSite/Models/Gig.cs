using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace GigSite.Models
{
    public class Gig
    {
        [Key]
        public int GigId {get;set;}

        [Required]
        public string Title {get;set;}

        [Required]
        public string Description {get;set;}

        [Required]
        public double Price {get;set;}
        
        [Required]
        public int DeliveryTime {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public int UserId {get;set;}

        public User Seller {get;set;}

        public List<OrderHistory> OrderHistory {get;set;}
    }
}