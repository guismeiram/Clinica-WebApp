using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Models.Validations
{
    public class ConsultaValidation : AbstractValidator<Consulta>
    {
        public ConsultaValidation()
        {
            RuleFor(f => f.Data)
                .NotEmpty().WithMessage("Data required");

            RuleFor(c => c.IdadePaciente)
             .NotEmpty().WithMessage("O campo {PropertyName} precisa de um IDADE")
             .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.NomePaciente)
                  .NotEmpty().WithMessage("O campo {PropertyName} precisa de um NOME")
                  .NotEmpty().WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.CpfPaciente)
             .NotEmpty().WithMessage("O campo {PropertyName} precisa de um CPF")
             .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.RgPaciente)
             .NotEmpty().WithMessage("O campo {PropertyName} precisa de um RG")
             .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.NomePaciente)
             .NotEmpty().WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

        }
    }
}
