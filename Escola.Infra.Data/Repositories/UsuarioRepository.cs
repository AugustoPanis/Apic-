using Escola.Domain.Entities;
using Escola.Domain.Interfaces;
using Escola.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace Escola.Infra.Repositories;

public class UsuarioRepository : IUsuarioRepository
{
    private readonly ApplicationDbContext _context;
    public UsuarioRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<Usuario> GetByIdAsync(int Id)
    {
       return await _context.Usuario.Where(x=> x.Excluido == false && x.Id == Id).FirstOrDefaultAsync();
    }

    public async Task<List<Usuario>> GetAllAsync()
    {
        return await _context.Usuario.Where(x => x.Excluido == false).ToListAsync();
    }

    public async Task<Usuario> UpdateAsync(Usuario usuario)
    { 
        _context.Usuario.Update(usuario);
        await _context.SaveChangesAsync();
        return usuario;
       
    }

    public async Task<Usuario> AddAsync(Usuario usuario)
    {
        _context.Usuario.Add(usuario);
        await _context.SaveChangesAsync();
        return usuario;
    }

    public async Task<Usuario> DeleteAsync(int Id)
    {
      var usuario = await _context.Usuario.Where(x=> x.Excluido ==  false && x.Id == Id).FirstOrDefaultAsync();
      if (usuario == null)
      {
          return null;
      }

      usuario.Excluido = true;
      _context.Usuario.Update(usuario);
      await _context.SaveChangesAsync();
      return usuario;
    }
}