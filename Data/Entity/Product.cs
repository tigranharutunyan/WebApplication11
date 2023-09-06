﻿using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication11.Data.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Description { get; set; } 
        public int Price  { get; set; }
        public int? Discount { get; set; }
        [ForeignKey("Vendor")]
        public int VendorId { get; set; }
        [ForeignKey("Catgeory")]
        public int CategoryId { get;set; }
        public Vendor Vendor { get; set; }  
        public Category Category { get; set; }  
    }
}
