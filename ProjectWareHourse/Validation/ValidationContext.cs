using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWareHourse.Validation
{
    public static class CustomValidation
    {
        public static MyValidationContext IsValid<T>(T context)
        {
            MyValidationContext myValidation = new MyValidationContext();
            ValidationContext validation = new ValidationContext(context, null, null);
            IList<ValidationResult> errors = new List<ValidationResult>();
            if (!Validator.TryValidateObject(context, validation, errors,true))
            {
                myValidation.IsValid = false;
                foreach (var item in errors)
                {
                    myValidation.results.Add(item);
                }

            }
            else
            {
                myValidation.IsValid = true;
            }
            return myValidation;
          
        }


    }
  



}
