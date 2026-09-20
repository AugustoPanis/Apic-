using Escola.Aplication.DTOs.Curso;

namespace Escola.Aplication.Services;

public interface ICursoService
{
    Task<CursoGetDTO> GetByIdAsync(int id);
    Task<List<CursoGetDTO>> GetAllAsync();
    Task<CursoGetDTO> UpdateAsync(CursoPutDTO cursoPutDto);
    Task<CursoGetDTO> AddAsync(CursoPostDTO cursoPostDto);
    Task<CursoGetDTO> DeleteAsync(int id);

}