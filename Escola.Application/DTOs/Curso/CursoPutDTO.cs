using System.ComponentModel.DataAnnotations;
namespace Escola.Aplication.DTOs.Curso;

public class CursoPutDTO
{
    [Required(ErrorMessage = "O identificador do curso é obrigatório")]
    public int Id { get; set; }

    [Required(ErrorMessage = "O campo nome é obrigatório")]
    [MaxLength(50, ErrorMessage = "O nome deve ter, no máximo 50 caracteres")]
    public string Nome { get; set; }
    
    [Required(ErrorMessage = "A descrição é obrigatória")]
    [MaxLength(150, ErrorMessage = "O nome deve ter, no descrição 150 caracteres")]
    public string Descricao { get; set; }
}