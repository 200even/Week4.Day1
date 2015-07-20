using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Week4.Day1.Models
{
    public class Student
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Hair Color")]
        public string HairColor { get; set; }
        
        public int HeightFeet { get; set; }
        public int HeightInches { get; set; }
        [Display(Name = "Height")]
        public string PrettyHeight
        {
            get
            {
                var feet = HeightInches / 12;
                var inches = HeightInches % 12;
                return string.Format(@"{0}'{1}""", feet, inches);
            }
        }
    }
}