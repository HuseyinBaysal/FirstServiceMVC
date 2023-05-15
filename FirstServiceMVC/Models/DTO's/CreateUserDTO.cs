using System.ComponentModel.DataAnnotations;

namespace FirstServiceMVC.Models.DTO_s
{
    public class CreateUserDTO
    {
        //View'da sadece doldurulacak olan kısımlar verilir. 

        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [MaxLength(50, ErrorMessage = "En fazla 50 karakter yazabilirsiniz")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [MaxLength(50, ErrorMessage = "En fazla 50 karakter yazabilirsiniz")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [EmailAddress(ErrorMessage = "Lütfen geçerli bir email adresi yazınız")]
        public string EMail { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [MaxLength(10, ErrorMessage = "Max 10 karakter yazabilirsiniz.")]
        public string Gender { get; set; }

    }
}
