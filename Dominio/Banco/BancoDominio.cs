using ApiPag.Model;
using ApiPag.Service.Interface;

namespace ApiPag.Dominio.Banco;

public class BancoDominio
{
    private readonly IBancoService _bancoService;
    public BancoDominio(IBancoService banco)
    {
        _bancoService = banco;
    }
    public BancoModel CadastroNovoBanco(BancoModel banco)
    {
        BancoModel BancoCad = _bancoService.CadastroNovoBanco(banco);
        return BancoCad;
    }
    public List<BancoModel> RetornarBanco()
    {
        return _bancoService.ListarBancos();
    }
    public BancoModel RetornarBanco(int CodigoUnico)
    {
        return _bancoService.ListarBancoId(CodigoUnico);
    }
}
