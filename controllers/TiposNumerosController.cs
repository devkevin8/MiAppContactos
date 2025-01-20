using MiAppContactos.Models;
using Microsoft.AspNetCore.Mvc;

namespace MiAppContactos.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TiposNumerosController : ControllerBase
{
    private readonly ITiposNumerosService _tiposNumerosService;
    public TiposNumerosController(ITiposNumerosService tiposNumerosService)
    {
        _tiposNumerosService = tiposNumerosService;
    }

    [HttpGet]
    public async Task<List<TiposNumero>> GetTiposNumeros()
    {
        return await _tiposNumerosService.GetTiposNumeros();
    }

    [HttpGet("{id}")]
    public async Task<TiposNumero> GetTiposNumero(int id)
    {
        return await _tiposNumerosService.GetTiposNumero(id);
    }

    [HttpPost]
    public async Task AddTiposNumero(TiposNumero tiposNumero)
    {
        await _tiposNumerosService.AddTiposNumero(tiposNumero);
    }

    [HttpPatch]
    public async Task UpdateTiposNumero(TiposNumero tiposNumero)
    {
        await _tiposNumerosService.UpdateTiposNumero(tiposNumero);
    }

    [HttpDelete("{id}")]
    public async Task DeleteTiposNumero(int id)
    {
        await _tiposNumerosService.DeleteTiposNumero(id);
    }
}
