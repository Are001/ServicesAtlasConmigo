using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlasLibraries.Model
{
    public class FechaPersonalizada: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null) return ValidationResult.Success;

            var str = value.ToString();

            if (!DateTime.TryParseExact(str, "yyyy-MM-dd", CultureInfo.InvariantCulture,
                DateTimeStyles.None, out _))
            {
                return new ValidationResult("La fecha debe tener formato yyyy-MM-dd.");
            }

            return ValidationResult.Success;
        }
    }
}
