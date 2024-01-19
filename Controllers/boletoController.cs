using ApiPag.Dominio.Boletos;
using ApiPag.Model;
using Microsoft.AspNetCore.Mvc;

namespace ApiPag.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BoletoController : ControllerBase
{
    private readonly BoletoDominio _BoletoDominio;

    public BoletoController(BoletoDominio boleto)
    {
        _BoletoDominio = boleto;
    }

    [HttpPost]
    public ActionResult<BoletoModel> Criar([FromBody] BoletoModel boleto)
    {
        return Ok(_BoletoDominio.CriarBoleto(boleto));

    }
    [HttpGet("boletoId/{id}")]
    public ActionResult<BoletoModel> BuscarBoletoId(int id)
    {
        return _BoletoDominio.BuscarBoleto(id);
    }

    [HttpGet]
    public ActionResult<List<BoletoModel>> BuscarTodosBoletos()
    {
        return _BoletoDominio.BuscarTodosBoletos();
    }

}
