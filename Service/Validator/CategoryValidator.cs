using DTO.AddOrUpdateDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Validator
{
    public class CategoryValidator : AbstractValidator<AddCategoryDTO>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name Alanı Boş Geçilemez");
            RuleFor(x => x.LanguageId).NotEmpty().WithMessage("LanguageId Alanı Boş Geçilemez");
        }
    }
}
