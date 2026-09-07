using Escola.Domain.Entities;
using Escola.Domain.Interfaces;

namespace Escola.Infra.Repositories;

public class MatriculaRepository : IMatriculaRepository
{
    public Task<Matricula> GetByIdAsync(int Id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Matricula>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Matricula> UpdateAsync(Matricula matricula)
    {
        throw new NotImplementedException();
    }

    public Task<Matricula> AddAsync(Matricula matricula)
    {
        throw new NotImplementedException();
    }

    public Task<Matricula> DeleteAsync(int Id)
    {
        throw new NotImplementedException();
    }
}