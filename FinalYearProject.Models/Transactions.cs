﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalYearProject.Models
{
    public class Transactions
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public AppUsers AppUsers { get; set; }
        public decimal Credit { get; set; }
        public decimal Debit { get; set; }
        public string TransType { get; set; }
        public string Remark { get; set; }
        public DateTime TransDate { get; set; }
    }
}
