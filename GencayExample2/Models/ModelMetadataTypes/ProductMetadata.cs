using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GencayExample2.Models.ModelMetadataTypes
{
    public class ProductMetadata
    {
        [Required(ErrorMessage = "Name must not empty")]
        [StringLength(100, ErrorMessage = "Name max length is 100")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Email must not empty")]
        [EmailAddress(ErrorMessage = "Email adress is not valid")]
        public string Email { get; set; }
    }
}
