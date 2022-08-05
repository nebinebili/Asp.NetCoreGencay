using GencayExample2.Models.ModelMetadataTypes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GencayExample2.Models
{
   // [ModelMetadataType(typeof(ProductMetadata))]
    public class Product
    {
        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public string Email { get; set; }
    }
}
