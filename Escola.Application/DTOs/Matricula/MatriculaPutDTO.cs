using System.ComponentModel.DataAnnotations;

namespace Escola.Aplication.DTOs.Matricula;

public class MatriculaPutDTO
{
    [Required(ErrorMessage = "O identificador de Matricula é necessario")]
    public int id { get; set; }
    
    [Required(ErrorMessage = "A data de exepiração é obrigatória")]
    public DateTime DataExpiracao { get; set; }
}