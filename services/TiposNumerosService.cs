using MiAppContactos.Models;
using Microsoft.EntityFrameworkCore;

namespace MiAppContactos.services;

public class TiposNumerosService : ITiposNumerosService
{
    private readonly ApplicationDbContext _context;
    public TiposNumerosService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<TiposNumero>> GetTiposNumeros()
    {
        return await _context.TiposNumeros.ToListAsync();
    }

    public async Task<TiposNumero> GetTiposNumero(int id)
    {
        return await _context.TiposNumeros.FirstAsync(x => x.Id == id);
    }

    public async Task<TiposNumero> AddTiposNumero(TiposNumero tiposNumero)
    {
        _context.TiposNumeros.Add(tiposNumero);
        await _context.SaveChangesAsync();
        return tiposNumero;
    }

    public async Task<TiposNumero> UpdateTiposNumero(TiposNumero tiposNumero)
    {
        _context.TiposNumeros.Update(tiposNumero);
        await _context.SaveChangesAsync();
        return tiposNumero;
    }

    public async Task<bool> DeleteTiposNumero(int id)
    {
        var tiposNumero = await _context.TiposNumeros.FirstAsync(x => x.Id == id);
        _context.TiposNumeros.Remove(tiposNumero);
        await _context.SaveChangesAsync();
        return true;
    }
}
