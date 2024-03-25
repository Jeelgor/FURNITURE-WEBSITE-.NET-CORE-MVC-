﻿using System.ComponentModel.DataAnnotations;

namespace FURNITURE.Models
{
    public class CheckoutViewModel
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal Quantity { get; set; }
        public string Images { get; set; }
    }
}