using DTO.AddOrUpdateDto;
using Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Validator
{
    public class NewsValidator : AbstractValidator<AddNewsDTO>
    {
        public NewsValidator()
        {
            RuleFor(x=>x.SeoKeyword).NotEmpty().WithMessage("SeoKeyword Alanı Boş Bırakılamaz");
            RuleFor(x => x.SeoTitle).NotEmpty().WithMessage("SeoTitle Alanı Boş Bırakılamaz");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title Alanı Boş Bırakılamaz");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Content Alanı Boş Bırakılamaz");
            RuleFor(x => x.SeoUrl).NotEmpty().WithMessage("SeoUrl Alanı Boş Bırakılamaz");
            
        }
    }
}
