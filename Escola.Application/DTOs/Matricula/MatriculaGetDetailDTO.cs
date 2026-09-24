using Escola.Aplication.DTOs.Turma;
using Escola.Aplication.DTOs.Usuario;

namespace Escola.Aplication.DTOs.Matricula;

public class MatriculaGetDetailDTO
{
    public int Id { get; set; }
    public UsuarioGetDTO Usuario { get; set; }
    public TurmaGetDTO Turma { get; set; }
    public DateTime DataMatricula { get; set; }
    public DateTime DataExpiracao { get; set; }
    public bool Ativo { get; set; }
}