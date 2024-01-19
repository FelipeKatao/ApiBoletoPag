using System.Collections;
using ApiPag.Dominio.Cliente;
using ApiPag.Model;
using ApiPag.Service;
using ApiPag.Service.Cliente;
using ApiPag.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ApiPag.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClienteController : ControllerBase
{

    private readonly ClienteDominio _clienteService;

    public ClienteController(ClienteDominio client)
    {
        _clienteService = client;
    }


    [HttpGet]
    public ActionResult<List<ClienteModel>> BuscarTodosUsuarios()
    { 
        List<ClienteModel> CLientes =  _clienteService.ListarTodosUsuarios();
        return Ok(CLientes);
    }

    [HttpGet("pagamentoscliente/{id}")]
    public ActionResult<ArrayList> PagamentosUsuarioId(int id)
    {
        return _clienteService.ClientePagamento(id);
    }

    [HttpPost]
    public ActionResult<ClienteModel> CriarNovoCliente([FromBody] ClienteModel clienteNovo)
    {
        return _clienteService.CriarNovocliente(clienteNovo);
    }

    [HttpPost("AuthCati")]
    public IActionResult Auth(string username,string password)
    {
        if(username == "felipe" && password == "1234"){
            ClienteModel a = new ClienteModel();
            var token = TokenService.GenerateToken(a);
            return Ok("Usuario Conectado com sucesso");
        }
        return BadRequest("Falha ao conectar");
    }
}
