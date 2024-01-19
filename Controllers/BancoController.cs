using ApiPag.Dominio.Banco;
using ApiPag.Model;
using Microsoft.AspNetCore.Mvc;

namespace ApiPag.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BancoController : ControllerBase
{
    private readonly BancoDominio _bancoDominio;

    public BancoController(BancoDominio banco)
    {
        _bancoDominio = banco;
    }

    [HttpPost]
    public ActionResult<BancoModel> CadastrarBanco(BancoModel banco)
    {
        return _bancoDominio.CadastroNovoBanco(banco);
    }
    [HttpGet]
    public ActionResult<List<BancoModel>> ListarBancos()
    {
        return _bancoDominio.RetornarBanco();
    }

    [HttpGet("codigounico/{codigo}")]
    public ActionResult<BancoModel> BuscarporCodigo(int codigo)
    {
        return _bancoDominio.RetornarBanco(codigo);
    }

}
