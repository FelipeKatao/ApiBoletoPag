using ApiPag.Model;

namespace ApiPag.Service.Interface;

public interface IBancoService
{
    BancoModel CadastroNovoBanco(BancoModel banco);
    List<BancoModel> ListarBancos();
    BancoModel ListarBancoId(int CodigoUnico);
}
