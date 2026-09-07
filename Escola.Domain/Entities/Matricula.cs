namespace Escola.Domain.Entities;

public class Matricula
{
    public int id { get; set; }
    public int UsuarioId { get; set; }
    public int TurmaId { get; set; }
    public DateTime DataMatricula { get; set; }
    public DateTime DataExpiracao { get; set; }
    public bool Ativo { get; set; }
    public Usuario Usuario { get; set; } 
    public Turma Turma { get; set; }
    
    public ICollection<Nota> Notas { get; set; }

}