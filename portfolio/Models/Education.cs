using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace portfolio.Models
{
    public class Education
    {
        [Key]
        public int Id { get; set; }
        public int StartYear { get; set; }
        public int? EndYear { get; set; }
        [ValidateNever]
        public bool IsCurrently_Enrolled { get; set; }
        public string CourseName { get; set; }
        public string? Description { get; set; }
        public decimal? GPA { get; set; }
        public string UniversityName { get; set; }
        public int PersonId { get; set; }
        [ValidateNever]
        public virtual PersonalInfo Person { get; set; }
    }
        

}
