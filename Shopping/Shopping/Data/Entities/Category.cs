using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
	public class Category
	{
        public int Id { get; set; }
        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(50, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres", MinimumLength = 4)]
        public string Name { get; set; }
    }
}
