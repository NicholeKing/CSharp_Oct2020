using System;
using System.ComponentModel.DataAnnotations;

namespace Bakery.Models
{
    public class Inventory
    {
        [Key]
        public int InventoryId {get;set;}

        public int ShopId {get;set;}
        public int GoodId {get;set;}
        public Shop Shop {get;set;}
        public Good Good {get;set;}
    }
}