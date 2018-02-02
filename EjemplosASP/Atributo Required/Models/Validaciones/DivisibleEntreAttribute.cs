using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Atributo_Required.Models.Validaciones
{
    public class DivisibleEntreAttribute: ValidationAttribute
    {
        private int _dividendo;

        public DivisibleEntreAttribute(int dividendo):base("El campo {0} no es divisible entre 3")
        {
            _dividendo = dividendo;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                if ((int)value % _dividendo != 0)
                {
                    var msjError = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(msjError);
                }
            }
            return ValidationResult.Success;
        }
    }
}