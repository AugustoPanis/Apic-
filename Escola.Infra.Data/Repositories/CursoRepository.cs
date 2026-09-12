using Escola.Domain.Interfaces;
using Escola.Domain.Entities;
using Escola.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace Escola.Infra.Repositories;
public class CursoRepository : ICursoRepository
{
    private readonly ApplicationDbContext _context;
    public CursoRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<Curso> GetByIdAsync(int Id)
    {
        return await _context.Curso.Where(x => x.Excluido == false && x.Id == Id).FirstOrDefaultAsync();
    }
    public async Task<List<Curso>> GetAllAsync()
    {
        return  await _context.Curso.Where(curso=> curso.Excluido == false).ToListAsync();

    }
    public async Task<Curso> UpdateAsync(Curso curso)
    {
        _context.Curso.Update(curso);
        await _context.SaveChangesAsync();
        return curso;
    }
    public async Task<Curso> AddAsync(Curso curso)
    {
        _context.Curso.Add(curso);
        await _context.SaveChangesAsync();
        return curso;
    }
    public async Task<Curso> DeleteAsync(int Id)
    {
        var curso = await _context.Curso.Where(x => x.Excluido ==  false && x.Id ==Id).FirstOrDefaultAsync();
        if (curso == null)
        {
            return null;
        }

        curso.Excluido = true;
        _context.Curso.Update(curso);
        await _context.SaveChangesAsync();
        return curso;
    }
}