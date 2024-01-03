using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyTask.Business.DTOs.CategoryDtos
{
    public class CategoryCreateDto
    {
        public string Name { get; set; }
        public int ParentCategoryId { get; set; }
    }
    public class CreateCategoryDTOValidation : AbstractValidator<CategoryCreateDto>
    {
        public CreateCategoryDTOValidation()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Title Field cannot be empty !")
                .NotNull()
                .WithMessage("Field cannot be null !");
            RuleFor(x => x.ParentCategoryId)
               .NotEmpty()
               .WithMessage("There's no Such Category w/This Id !");
        }
    }
}
