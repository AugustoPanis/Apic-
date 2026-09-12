using Escola.Domain.Entities;
using Escola.Domain.Interfaces;
using Escola.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Escola.Infra.Repositories;

public class MatriculaRepository : IMatriculaRepository
{
    private readonly ApplicationDbContext _context;
    public MatriculaRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<Matricula> GetByIdAsync(int Id)
    {
       return await _context.Matricula.Where(x => x.Excluido == false && x.id == Id).FirstOrDefaultAsync();
    }

    public async Task<List<Matricula>> GetAllAsync()
    {
       return await _context.Matricula.Where(x => x.Excluido == false).ToListAsync();
    }

    public async Task<Matricula> UpdateAsync(Matricula matricula)
    { 
        _context.Matricula.Update(matricula);
        await _context.SaveChangesAsync();
        return matricula;
    }

    public async Task<Matricula> AddAsync(Matricula matricula)
    {
        _context.Matricula.Add(matricula);
        await _context.SaveChangesAsync();
        return matricula;
    }

    public async Task<Matricula> DeleteAsync(int Id)
    {
        var matricula = await _context.Matricula.Where(x => x.Excluido == false && x.id == Id).FirstOrDefaultAsync();
        if (matricula == null)
        {
            return null;
        }
        matricula.Excluido = true;
        _context.Matricula.Update(matricula);
        await _context.SaveChangesAsync();
        
        return matricula;
    }
}