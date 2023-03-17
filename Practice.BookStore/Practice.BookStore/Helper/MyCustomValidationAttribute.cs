using System.ComponentModel.DataAnnotations;

namespace Practice.BookStore.Helper
{
    public class MyCustomValidationAttribute:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value!=null&&!value.ToString().StartsWith(" "))
            {
                string bookName = value.ToString();
                if(bookName.Contains("mvc"))
                {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult("Book Name does not contain desired value Or Contains Empty String !");
        }
    }
}
