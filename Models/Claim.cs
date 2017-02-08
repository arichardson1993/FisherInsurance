using System;
using Microsoft.AspNetCore.Mvc;

namespace FisherInsurance.Models
 
{
    public class Claim
    {
        public int Id { get; set; }

        public string PolicyType { get; set; } 

        public DateTime LossDate { get; set; } 

        public decimal Price { get; set; }
    }   
}