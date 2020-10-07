using System.ComponentModel.DataAnnotations;
using System;

namespace ValidDemo.Models
{
    public class CampingTrip
    {
        [Required]
        [MinLength(3)]
        public string Name{get;set;}


        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name="when does it start?")]
        [FutureDate]
        public DateTime StartDate{get;set;}

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime EndDate{get;set;}

        [Required]
        [MinLength(5,ErrorMessage = "you need 5 characters yo!!!")]
        public string Location{get;set;}

        public string BearProtection{get;set;}
    }

    public class FutureDate : ValidationAttribute{
        protected override ValidationResult IsValid(object value, ValidationContext validationContext){
            if(value is DateTime){
                DateTime check = (DateTime) value;

                if(check > DateTime.Now){
                    return ValidationResult.Success;
                }
                else return new ValidationResult("pick a future date instead of time travelling!!!");
            }
            else{
                return new ValidationResult("that's not a date!");
            }
        }
    }
}