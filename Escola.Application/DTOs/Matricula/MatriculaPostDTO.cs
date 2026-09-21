using System.ComponentModel.DataAnnotations;

namespace Escola.Aplication.DTOs.Matricula;

public class MatriculaPostDTO
{
    [Required(ErrorMessage = "O identificador do usuário é necessario")]
    public int UsuarioId { get; set; }
    
    [Required(ErrorMessage = "O identificador de turma é necessario")]
    public int TurmaId { get; set; }

    [Required(ErrorMessage = "A data de exepiração é obrigatória")]
    public DateTime DataExpiracao { get; set; }
}