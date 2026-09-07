using Escola.Domain.Entities;

namespace Escola.Domain.Interfaces;


public interface INotaRespositoryRepository
{
    Task<Nota> GetByIdAsync(int Id);
    Task<List<Nota>> GetAllAsync();
    Task<Nota> UpdateAsync(Nota nota);
    Task<Nota> AddAsync(Nota nota);
    Task<Nota> DeleteAsync(int Id);
    
}