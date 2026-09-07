using System.Reflection.Metadata;
using Escola.Domain.Entities;

namespace Escola.Domain.Interfaces;

public interface ITurmaRepository
{
    Task<Turma> GetByIdAsync(int Id);
    Task<List<Turma>> GetAllAsync();
    Task<Turma> UpdateAsync(Turma turma);
    Task<Turma> AddAsync(Turma turma);
    Task<Turma> DeleteAsync(int Id);
}