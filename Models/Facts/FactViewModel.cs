using ApiTestFramework.Models.Properties.Facts;
using System;

namespace ApiTestFramework.Models.Facts
{
    public class FactViewModel
    {
        public StatusViewModel status { get; set; }
        public string _id { get; set; }
        public int __v { get; set; }
        public string text { get; set; }
        public DateTime updatedAt { get; set; }
        public bool deleted { get; set; }
        public string source { get; set; }
    }
}
