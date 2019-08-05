using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class Order
    {
        [ForeignKey("Customer")]
        public virtual int CustomerId { set; get; }

        public virtual Customer Customer { set; get; }

        [Key]
        public int OrderId { set; get; }
        [DisplayName("Tax")]
        public double Tax { set; get; }

        [DisplayName("Pre-Tax Amount")]
        public double PreTaxAmount { set; get; }

        [DisplayName("Total Amount")]
        public double TotalAmount { set; get; }

        [DisplayName("Paid")]
        public bool Pay { set; get; }

        [DisplayName("Date of Order")]
        public DateTime DateCreated { set; get; }

        public virtual List<Item> ItemList { set; get; }

        public Order()
        {
            ItemList = new List<Item>();
        }
    }

}
