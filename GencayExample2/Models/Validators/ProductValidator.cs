using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GencayExample2.Models.Validators
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email must not empty").EmailAddress().WithMessage("Email is not valid");
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Product Name must not empty")
                .MaximumLength(100).WithMessage("Max length is not big 100 character");

        }

    }
}
