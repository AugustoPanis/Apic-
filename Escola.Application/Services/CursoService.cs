using Escola.Aplication.DTOs.Curso;
using Escola.Domain.Entities;
using Escola.Domain.Interfaces;

namespace Escola.Aplication.Services;

public class CursoService : ICursoService
{
    private readonly  ICursoRepository _cursoRepository;

    public CursoService (ICursoRepository cursoRepository)
    {
        _cursoRepository = cursoRepository;
        
    }

    public async Task<CursoGetDTO> GetByIdAsync(int id)
    {
        var curso = await _cursoRepository.GetByIdAsync(id);
        if (curso == null)
        {
            return null;
        }
        return new CursoGetDTO
        {
            Id = curso.Id,
            Nome = curso.Nome,
            Descricao = curso.Descricao
        };
    }

    public async Task<List<CursoGetDTO>> GetAllAsync()
    {
        var cursos = await _cursoRepository.GetAllAsync();
        var cursoGetDTOs = new List<CursoGetDTO>();
        foreach (var curso in cursos)
        {
            cursoGetDTOs.Add(new CursoGetDTO
            {
                Id = curso.Id,
                Nome = curso.Nome,
                Descricao = curso.Descricao
            });
        }
        return cursoGetDTOs;
    }

    public async Task<CursoGetDTO> UpdateAsync(CursoPutDTO cursoPutDto)
    {
        var curso = new Curso
        {
            Id = cursoPutDto.Id,
            Nome = cursoPutDto.Nome,
            Descricao = cursoPutDto.Descricao,
        };
        var  updatedCurso = _cursoRepository.UpdateAsync(curso);
        if (updatedCurso == null)
        {
            return null;
        }
        return new CursoGetDTO()
        {
            Id = curso.Id,
            Nome = curso.Nome,
            Descricao = cursoPutDto.Descricao,
        };
    }

    public async Task<CursoGetDTO> AddAsync(CursoPostDTO cursoPostDto)
    {
        var curso = new Curso
        {
            Nome = cursoPostDto.Nome,
            Descricao = cursoPostDto.Descricao,
        };
        var createdCurso = await _cursoRepository.AddAsync(curso);
        if (createdCurso == null)
        {
            return null;
        }
        return new CursoGetDTO
        {
            Id = createdCurso.Id,
            Nome = createdCurso.Nome,
            Descricao = createdCurso.Descricao,
        };
    }

    public async Task<CursoGetDTO> DeleteAsync(int id)
    {
        var deleteCurso = await _cursoRepository.DeleteAsync(id);
        if (deleteCurso == null)
        {
            return null;
        }
        return new CursoGetDTO
        {
            Id = deleteCurso.Id,
            Nome = deleteCurso.Nome,
            Descricao = deleteCurso.Descricao,
        };
    }
}