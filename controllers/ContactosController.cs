using System.Threading.Channels;
using MiAppContactos.DTOs;
using MiAppContactos.Models;
using Microsoft.AspNetCore.Mvc;
using MyWorkerService;

namespace MiAppContactos.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ContactosController : ControllerBase
{
    private readonly Channel<int> _channel;
    private readonly IContactosService _contactosService;
    public ContactosController(Channel<int> channel, IContactosService contactosService)
    {
        _channel = channel;
        _contactosService = contactosService;
    }

    [HttpGet]
    public async Task<List<GetContactosDTO>> GetContactos()
    {
        return await _contactosService.GetContactos();
    }

    [HttpGet("{id}")]
    public async Task<Contacto> GetContacto(int id)
    {
        //adding worker to the controller
        _channel.Writer.WriteAsync(id);
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
