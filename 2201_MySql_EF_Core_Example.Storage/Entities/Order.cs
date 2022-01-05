﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2201_MySql_EF_Core_Example.Storage.Entities
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string ItemName { get; set; }

        [Required]
        public int ItemCount { get; set; }

        [Required]
        public int CustomerId { get; set; }
    }
}
