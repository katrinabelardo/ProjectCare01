using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjectCare01.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        [Required(ErrorMessage ="Required.")]
        public string OrderName { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Required(ErrorMessage ="Required.")]
        public decimal Price { get; set; }
        [Display(Name="Date Added")]
        public DateTime DateAdded { get; set; }
        [Display(Name ="Date Modified")]
        public DateTime? DateModified { get; set; }
        [Display(Name ="Order Type")]
        public OrderType Type { get; set; }
        public enum OrderType
        {
            PreOrder =1,
            OnHand=2
        }
    }
}
