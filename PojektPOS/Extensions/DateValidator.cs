using System.ComponentModel.DataAnnotations;

namespace PojektPOS.Extensions
{
    public class DateValidator
    {
        public static ValidationResult ValidationResultDate(DateTime dateTime)
        {

            if (dateTime.Date > DateTime.Now.Date)
                return new ValidationResult($"Your date must be less or equale {dateTime:yyyy-MM-dd}");
            else
                return ValidationResult.Success;
        }
    }
}
