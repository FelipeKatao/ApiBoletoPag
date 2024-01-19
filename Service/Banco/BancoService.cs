using ApiPag.Model;
using ApiPag.Repository.Interfaces;
using ApiPag.Service.Interface;

namespace ApiPag.Service.Banco;

public class BancoService:IBancoService
{
    private readonly IBanco _banco;
    public BancoService(IBanco banco)
    {
        _banco = banco;
    }

    public BancoModel CadastroNovoBanco(BancoModel banco)
    {
       return _banco.CadastrarBanco(banco);
    }

    public BancoModel ListarBancoId(int CodigoUnico)
    {
        return _banco.ListarBancos(CodigoUnico);
    }


    public List<BancoModel> ListarBancos()
    {
        return _banco.ListarBancos();
    }
}
