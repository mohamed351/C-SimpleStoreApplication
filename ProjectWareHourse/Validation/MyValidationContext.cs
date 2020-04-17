using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectWareHourse.Validation
{
    public class MyValidationContext
    {
        public MyValidationContext()
        {
            results = new List<ValidationResult>();
        }
        public bool IsValid { get; set; }
        public List<ValidationResult> results { get; set; }
    }
  



}
