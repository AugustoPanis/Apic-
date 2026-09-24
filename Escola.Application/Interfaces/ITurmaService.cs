using Escola.Aplication.DTOs.Turma;

namespace Escola.Aplication.Services;

public interface ITurmaService
{
    Task<TurmaGetDTO> GetByIdAsync(int Id);
    Task<List<TurmaGetDTO>> GetAllAsync();
    Task<TurmaGetDTO> UpdateAsync(TurmaPutDTO turma);
    Task<TurmaGetDTO> AddAsync(TurmaPostDTO turma);
    Task<TurmaGetDTO> DeleteAsync(int Id);
}