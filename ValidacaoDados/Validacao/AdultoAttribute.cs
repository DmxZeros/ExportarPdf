using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using ValidacaoDados.Models;

namespace ValidacaoDados.Validacao
{
    public class AdultoAttribute: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Pessoa pessoa = (Pessoa)validationContext.ObjectInstance;

            if(pessoa.Idade < 18) 
            {
                return new ValidationResult("Apenas adultos podem se cadastrar !");
            }

            return ValidationResult.Success;
        }
    }
}
