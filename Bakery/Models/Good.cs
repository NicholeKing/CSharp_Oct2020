using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bakery.Models
{
    public class Good
    {
        [Key]
        public int GoodId {get;set;}

        [Required(ErrorMessage="Name your creation!")]
        public string GoodName {get;set;}

        [Required(ErrorMessage="Calories is required")]
        [Range(1,10000)]
        public int Calories {get;set;}

        [Required(ErrorMessage="Pics or it didn't happen")]
        public string Photo {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        public List<Inventory> ShopsSoldAt {get;set;}
    }
}