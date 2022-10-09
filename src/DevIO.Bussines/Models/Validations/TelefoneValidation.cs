using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Models.Validations
{
    public class TelefoneValidation : AbstractValidator<Telefone>
    {
        public TelefoneValidation()
        {
            RuleFor(c => c.ddd)
             .NotEmpty().WithMessage("O campo {PropertyName} precisa do DDD")
             .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.numero)
             .NotEmpty().WithMessage("O campo {PropertyName} precisa do Numero")
             .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            
        }
    }
}
