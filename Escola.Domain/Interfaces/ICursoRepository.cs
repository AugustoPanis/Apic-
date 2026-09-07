using System.Reflection.Metadata;
using Escola.Domain.Entities;

namespace Escola.Domain.Interfaces;

public interface ICursoRepository
{
    Task<Curso> GetByIdAsync(int Id);
    Task<List<Curso>> GetAllAsync();
    Task<Curso> UpdateAsync(Curso curso);
    Task<Curso> AddAsync(Curso curso);
    Task<Curso> DeleteAsync(int Id);

}