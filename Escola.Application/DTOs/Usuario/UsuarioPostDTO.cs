using System.ComponentModel.DataAnnotations;

namespace Escola.Aplication.DTOs.Usuario;

public class UsuarioPostDTO
{
    [Required(ErrorMessage = "O nome é obrigatório")]
    [MaxLength(250, ErrorMessage = "O nome deve ter no máximo 250 caracteres")]
    public string Nome { get; set; }
    
    [Required(ErrorMessage = "O email é obrigatório")]
    public string Email { get; set; }
    
    [Required(ErrorMessage = "O perfil é obrigatório")]
    public string Perfil  { get; set; }
}