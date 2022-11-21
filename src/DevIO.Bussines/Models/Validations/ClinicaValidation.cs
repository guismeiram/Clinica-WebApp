using DevIO.Bussines.Models.Validations.Documentos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Models.Validations
{
    public class ClinicaValidation : AbstractValidator<Clinica>
    {
        public ClinicaValidation()
        {
            RuleFor(c => c.Nome)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa de um Nome")
                .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.Telefone)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa de um Nome")
                .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.Ddd)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa de um Nome")
                .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            /*public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Ddd { get; set; }*/
        }

    }
}
