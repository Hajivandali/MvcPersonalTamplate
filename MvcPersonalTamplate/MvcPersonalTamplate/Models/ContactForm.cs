
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace MvcPersonalTamplate.Models
{
    public class ContactForm
    {
        [Required(ErrorMessage ="فیلد اجباری است ")]
        [MinLength(3)]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required(ErrorMessage = "فیلد اجباری است ")]
        [EmailAddress(ErrorMessage ="مقدار وارد شده صحیح نیست")]
        public string Email { get; set; }  
        public string Message { get; set; }
        public SelectList Services { get; set; }
    }
}
