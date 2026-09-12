namespace Escola.Domain.Entities;

public class Turma
{
    public int Id { get; set; }
    public int IdCurso { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public Curso Curso { get; set; }
    public bool Excluido { get; set; }
    public ICollection<Matricula> Matriculas { get; set; }

}