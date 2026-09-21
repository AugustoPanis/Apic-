namespace Escola.Aplication.DTOs.Matricula;

public class MatriculaGetDTO
{
    public int id { get; set; }
    public int UsuarioId { get; set; }
    public int TurmaId { get; set; }
    public DateTime DataMatricula { get; set; }
    public DateTime DataExpiracao { get; set; }
    public bool Ativo { get; set; }
}