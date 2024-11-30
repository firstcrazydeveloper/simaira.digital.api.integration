namespace Ecolab.Simaira.Digital.CustomerPortal.Model.System.ShiftModels
{
    using global::System.Collections.Generic;
    using global::System.ComponentModel.DataAnnotations;
    using global::System.Linq;

    public class CustomDayNameValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            List<string> strDays = value.ToString().Replace(" ","").Replace("(", "").Replace(")", "").Split(",").ToList();
            var newItems = strDays.Except(Constants.ShiftDayOfWeekAry);
            return !(newItems != null && newItems.Count() > 0);
        }
    }
}