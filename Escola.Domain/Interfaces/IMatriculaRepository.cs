using System.Reflection.Metadata;
using Escola.Domain.Entities;

namespace Escola.Domain.Interfaces;

public interface IMatriculaRepository
{
    Task<Matricula> GetByIdAsync(int Id);
    Task<List<Matricula>> GetAllAsync();
    Task<Matricula> UpdateAsync(Matricula matricula);
    Task<Matricula> AddAsync(Matricula matricula);
    Task<Matricula> DeleteAsync(int Id);
}