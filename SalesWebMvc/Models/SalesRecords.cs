﻿using SalesWebMvc.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class SalesRecords
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecords() { }

        public SalesRecords(int id, DateTime daate, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = Date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }

    }
}
