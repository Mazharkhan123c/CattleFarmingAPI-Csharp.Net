//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CattleFarmingAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FoodCalculate
    {
        public int ID { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public string Date { get; set; }
        public string Item { get; set; }
        public Nullable<decimal> Price { get; set; }
        public int FarmId { get; set; }
    }
}