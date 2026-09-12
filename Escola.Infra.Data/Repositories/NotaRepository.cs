using Escola.Domain.Entities;
using Escola.Domain.Interfaces;
using Escola.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace Escola.Infra.Repositories;

public class NotaRepository : INotaRespositoryRepository
{
    private readonly ApplicationDbContext _context;
    public NotaRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<Nota> GetByIdAsync(int Id)
    {
        return await _context.Nota.Where(x => x.Excluido == false && x.Id == Id).FirstOrDefaultAsync();
    }

    public async Task<List<Nota>> GetAllAsync()
    {
        return await _context.Nota.Where(x => x.Excluido == false).ToListAsync();
    }

    public async Task<Nota> UpdateAsync(Nota nota)
    {
        _context.Nota.Update(nota);
        await _context.SaveChangesAsync();
        return nota;
    }

    public async Task<Nota> AddAsync(Nota nota)
    { 
        _context.Nota.AddAsync(nota);
        await _context.SaveChangesAsync();
        return nota;
    }

    public async Task<Nota> DeleteAsync(int Id)
    {
        var nota = await _context.Nota.Where(x => x.Excluido == false && x.Id == Id).FirstOrDefaultAsync();
        if (nota == null)
        {
            return null;
        }

        nota.Excluido = true;
        _context.Update(nota);
        await _context.SaveChangesAsync();
        return nota;
    }
}