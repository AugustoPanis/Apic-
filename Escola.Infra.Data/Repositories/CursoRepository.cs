using Escola.Domain.Interfaces;
using Escola.Domain.Entities;

namespace Escola.Infra.Repositories;
public class CursoRepository : ICursoRepository
{
    public Task<Curso> GetByIdAsync(int Id)
    {
        throw new NotImplementedException();
        
    }
    public Task<List<Curso>> GetAllAsync()
    {
        throw new NotImplementedException();
   
    }
    public  Task<Curso> UpdateAsync(Curso curso)
    {
        throw new NotImplementedException();
    }
    public Task<Curso> AddAsync(Curso curso)
    {
        throw new NotImplementedException();
    }
    public Task<Curso> DeleteAsync(int Id)
    {
        throw new NotImplementedException();
    }
}