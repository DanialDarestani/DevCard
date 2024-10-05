using System.ComponentModel.DataAnnotations;

namespace DevCard___Project.Models;

public class Contact
{
    [Required(ErrorMessage = "نام را وارد کنید!")]
    [MinLength(3, ErrorMessage = "حداقل سه کاراکتر!")]
    public string Name { get; set; }

    [Required(ErrorMessage = "ایمیل را وارد کنید!")]
    [EmailAddress]
    public string Email { get; set; }

    [Required(ErrorMessage = "نام سرویس را انتخاب کنید!")]
    public string Service { get; set; }

    [Required(ErrorMessage = "پیام را وارد کنید!")]
    public string Message { get; set; }
}