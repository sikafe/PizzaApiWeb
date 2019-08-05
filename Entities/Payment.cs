using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class Payment
    {
        [Key]
        public int PaymentId { set; get; }

        [ForeignKey("Customer")]
        public virtual int CustomerId { set; get; }

        public virtual Customer Customer { set; get; }

        [DataType(DataType.CreditCard)]
        [DisplayName("Credit Card Number")]
        public string CardNumber { set; get; }
        [DisplayName("Security Code")]
        public string SecurityCode { set; get; }

        [ForeignKey("CardType")]
        public virtual int  CardTypeId { set; get; }
        public virtual CardType CardType { set; get; }

        [MaxLength(50), MinLength(2)]
        public string Address { get; set; }
        public string City { get; set; }
        [MaxLength(50), MinLength(2)]
        public string State { get; set; }

        [DisplayName("Zip Code")]
        [DataType(DataType.PostalCode)]
        public int ZipCode { get; set; }
        [DisplayName("Date Added")]
        public DateTime DateCreated { set; get; }
        [DisplayName("Expiration Date")]
        public DateTime ExpDate { set; get; }
    }
}
