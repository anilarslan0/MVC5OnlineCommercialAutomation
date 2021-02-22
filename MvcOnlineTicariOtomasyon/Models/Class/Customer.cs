﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Class
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CustomerName { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CustomerSurname { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(13)]
        public string CustomerCity { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string CustomerMail { get; set; }
        public ICollection<SalesAction> SalesActions { get; set; }

    }
}