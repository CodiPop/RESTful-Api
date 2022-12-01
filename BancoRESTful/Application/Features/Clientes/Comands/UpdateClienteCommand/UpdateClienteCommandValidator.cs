﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Clientes.Comands.UpdateClienteCommand
{
    public class DeleteClienteCommandValidator : AbstractValidator<UpdateClienteCommand>
    {
        public DeleteClienteCommandValidator()
        {
            RuleFor(p => p.Nombre)
                .NotEmpty().WithMessage("{PropertyName} no puede ser vacio.")
                .MaximumLength(80).WithMessage("{PropertyName} no debe exceder de {MaxLength}");

            RuleFor(p => p.Apellido)
            .NotEmpty().WithMessage("{PropertyName} no puede ser vacio.")
            .MaximumLength(80).WithMessage("{PropertyName} no debe exceder de {MaxLength}");

            RuleFor(p => p.FechaNacimiento)
            .NotEmpty().WithMessage(" Fecha de nacimiento no puede ser vacio.");


            RuleFor(p => p.Telefono)
            .NotEmpty().WithMessage("{PropertyName} no puede ser vacio.")
            .Matches(@"^\d{4}-\d{4}$").WithMessage("{PropertyName} debe cumplir el formato 0000-0000")
            .MaximumLength(9).WithMessage("{PropertyName} no debe exceder de {MaxLength}");

            RuleFor(p => p.Email)
            .NotEmpty().WithMessage("{PropertyName} no puede ser vacio.")
            .EmailAddress().WithMessage("{PropertyName debe ser una direccion de Email valida}")
            .MaximumLength(100).WithMessage("{PropertyName} no debe exceder de {MaxLength}");


            RuleFor(p => p.Direccion)
            .NotEmpty().WithMessage("{PropertyName} no puede ser vacio.")
            .MaximumLength(120).WithMessage("{PropertyName} no debe exceder de {MaxLength}");



        }
    }
}