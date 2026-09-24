using System.ComponentModel.DataAnnotations;
using Escola.Aplication.DTOs.Usuario;
using Escola.Domain.Entities;
using Escola.Domain.Interfaces;

namespace Escola.Aplication.Services;

public class UsuarioService : IUsuarioService
{
    private readonly IUsuarioRepository _usuarioRepository;

    public UsuarioService(IUsuarioRepository usuarioRepository)
    {
        _usuarioRepository = usuarioRepository;
    }
    
    public async Task<UsuarioGetDTO> GetByIdAsync(int Id)
    {
        var usuario = await _usuarioRepository.GetByIdAsync(Id);
        if (usuario == null)
        {
            return null;
        }
        return new UsuarioGetDTO
        {
            Id = usuario.Id,
            Nome = usuario.Nome,
            Email = usuario.Email
        };
    }

    public async Task<List<UsuarioGetDTO>> GetAllAsync()
    {
        var usuarios = await _usuarioRepository.GetAllAsync();
        var usuarioGetDTO = new List<UsuarioGetDTO>();
        foreach (var usuario in usuarios)
        {
            usuarioGetDTO.Add(new UsuarioGetDTO()
            {
                Id = usuario.Id,
                Nome = usuario.Nome,
                Email = usuario.Email
            });
        }

        return usuarioGetDTO;
    }

    public async Task<UsuarioGetDTO> UpdateAsync(UsuarioPutDTO usuario)
    {
        var usuarioUpdate = new Usuario()
        {
            Nome = usuario.Nome,
            Email = usuario.Email,

        };
        _usuarioRepository.UpdateAsync(usuarioUpdate);
        return new UsuarioGetDTO
        {
            Nome = usuarioUpdate.Nome,
            Email = usuario.Email

        };
    }

    public Task<UsuarioGetDTO> AddAsync(UsuarioPostDTO usuario)
    {
        throw new NotImplementedException();
    }

    public Task<UsuarioGetDTO> DeleteAsync(int Id)
    {
        throw new NotImplementedException();
    }
}