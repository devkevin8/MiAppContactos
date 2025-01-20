using MiAppContactos.Models;
using Microsoft.EntityFrameworkCore;

namespace MiAppContactos.services;

public class ContactosService : IContactosService
{
    private readonly ApplicationDbContext _context;
    public ContactosService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Contacto>> GetContactos()
    {
        return await _context.Contactos.ToListAsync();
    }

    public async Task<Contacto> GetContacto(int id)
    {
        return await _context.Contactos.FirstAsync(x => x.Id == id);
    }

    public async Task<Contacto> AddContacto(Contacto contacto)
    {
        _context.Contactos.Add(contacto);
        await _context.SaveChangesAsync();
        return contacto;
    }

    public async Task<Contacto> UpdateContacto(Contacto contacto)
    {
        _context.Entry(contacto).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return contacto;
    }

    public async Task<bool> DeleteContacto(int id)
    {
        var contacto = await _context.Contactos.FirstAsync(x => x.Id == id);
        _context.Contactos.Remove(contacto);
        await _context.SaveChangesAsync();
        return true;
    }
}
