using ApiPag.Model;

namespace ApiPag.Repository.Interfaces;

public interface IBanco
{
    public BancoModel CadastrarBanco(BancoModel Banco);
    public List<BancoModel> ListarBancos();
    public BancoModel ListarBancos(int CodigoUnico);
}
