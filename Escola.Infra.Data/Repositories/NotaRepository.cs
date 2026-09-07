using Escola.Domain.Entities;
using Escola.Domain.Interfaces;

namespace Escola.Infra.Repositories;

public class NotaRepository : INotaRespositoryRepository
{
    public Task<Nota> GetByIdAsync(int Id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Nota>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Nota> UpdateAsync(Nota nota)
    {
        throw new NotImplementedException();
    }

    public Task<Nota> AddAsync(Nota nota)
    {
        throw new NotImplementedException();
    }

    public Task<Nota> DeleteAsync(int Id)
    {
        throw new NotImplementedException();
    }
}