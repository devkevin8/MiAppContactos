using MiAppContactos.Models;
using Microsoft.AspNetCore.Mvc;

namespace MiAppContactos.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ContactosController : ControllerBase
{
    private readonly IContactosService _contactosService;
    public ContactosController(IContactosService contactosService)
    {
        _contactosService = contactosService;
    }

    [HttpGet]
    public async Task<List<Contacto>> GetContactos()
    {
        return await _contactosService.GetContactos();
    }

    [HttpGet("{id}")]
    public async Task<Contacto> GetContacto(int id)
    {
        return await _contactosService.GetContacto(id);
    }

    [HttpPost]
    public async Task AddContacto(Contacto contacto)
    {
        await _contactosService.AddContacto(contacto);
    }

    [HttpPatch]
    public async Task UpdateContacto(Contacto contacto)
    {
        await _contactosService.UpdateContacto(contacto);
    }

    [HttpDelete("{id}")]
    public async Task DeleteContacto(int id)
    {
        await _contactosService.DeleteContacto(id);
    }
}
