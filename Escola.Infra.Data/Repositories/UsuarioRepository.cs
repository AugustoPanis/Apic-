using Escola.Domain.Entities;
using Escola.Domain.Interfaces;

namespace Escola.Infra.Repositories;

public class UsuarioRepository : IUsuarioRepository
{
    public Task<Usuario> GetByIdAsync(int Id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Usuario>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Usuario> UpdateAsync(Usuario usuario)
    {
        throw new NotImplementedException();
    }

    public Task<Usuario> AddAsync(Usuario usuario)
    {
        throw new NotImplementedException();
    }

    public Task<Usuario> DeleteAsync(int Id)
    {
        throw new NotImplementedException();
    }
}