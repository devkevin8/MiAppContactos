using MiAppContactos.Models;
using Microsoft.EntityFrameworkCore;

namespace MiAppContactos.services;

public class UsuariosService : IUsuariosService
{
    private readonly ApplicationDbContext _context;

    public UsuariosService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Usuario>> GetUsuarios()
    {
        return await _context.Usuarios.ToListAsync();
    }

    public async Task<Usuario> GetUsuario(int id)
    {
        return await _context.Usuarios.FirstAsync(x => x.Id == id);
    }

    public async Task<Usuario> AddUsuario(Usuario usuario)
    {
        _context.Usuarios.Add(usuario);
        await _context.SaveChangesAsync();
        return usuario;
    }

    public async Task<Usuario> UpdateUsuario(Usuario usuario)
    {
        _context.Usuarios.Update(usuario);
        await _context.SaveChangesAsync();
        return usuario;
    }

    public async Task<bool> DeleteUsuario(int id)
    {
        var usuario = await _context.Usuarios.FirstAsync(x => x.Id == id);
        _context.Usuarios.Remove(usuario);
        await _context.SaveChangesAsync();
        return true;
    }
}