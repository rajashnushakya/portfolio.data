using MessagePack;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace portfolio.Models
{
    public class MyExpertise
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int  PersonId { get; set; }
        [ValidateNever]
        public virtual PersonalInfo Person { get; set; }

    }
}
