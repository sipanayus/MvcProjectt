﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adı Boş Geçilmez");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklama Boş Geçilmez");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("En az 3 karakter girilmeli");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("En fazla 20 karakter girilmeli");

        }
    }
}
