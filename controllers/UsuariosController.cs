using MiAppContactos.Models;
using Microsoft.AspNetCore.Mvc;

namespace MiAppContactos.controllers;

[Route("api/[controller]")]
[ApiController]
public class UsuariosController : ControllerBase
{
    private readonly IUsuariosService _usuariosService;

    public UsuariosController(IUsuariosService usuariosService)
    {
        _usuariosService = usuariosService;
    }

    [HttpGet]
    public async Task<List<Usuario>> GetUsuarios()
    {
        return await _usuariosService.GetUsuarios();
    }

    [HttpGet("{id}")]
    public async Task<Usuario> GetUsuario(int id)
    {
        return await _usuariosService.GetUsuario(id);
    }

    [HttpPost]
    public async Task<Usuario> AddUsuario(Usuario usuario)
    {
        return await _usuariosService.AddUsuario(usuario);
    }

    [HttpPatch]
    public async Task<Usuario> UpdateUsuario(Usuario usuario)
    {
        return await _usuariosService.UpdateUsuario(usuario);
    }

    [HttpDelete("{id}")]
    public async Task<bool> DeleteUsuario(int id)
    {
        return await _usuariosService.DeleteUsuario(id);
    }
}