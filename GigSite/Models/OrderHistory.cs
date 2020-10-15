using System;
using System.ComponentModel.DataAnnotations;

namespace GigSite.Models
{
    public class OrderHistory
    {
        [Key]
        public int OrderId {get;set;}

        //Purchased a gig
        public int UserId {get;set;}

        //Gig purchased
        public int GigId {get;set;}

        public string Request {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public User Client {get;set;}
        public Gig Gig {get;set;}
    }
}