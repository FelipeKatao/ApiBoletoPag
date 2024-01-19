using ApiPag.Data.Bano_dados;
using ApiPag.Model;
using ApiPag.Repository.Interfaces;

namespace ApiPag.Repository.Bancos;

public class BancosRepository : IBanco
{
    private readonly BancoContext _Banco;
    public BancosRepository(BancoContext Banco)
    {
        _Banco = Banco;
    }
    public BancoModel CadastrarBanco(BancoModel Banco)
    {
        _Banco.Banco.Add(Banco);
        _Banco.SaveChanges();

        return Banco;
    }

    public List<BancoModel> ListarBancos()
    {
        return _Banco.Banco.ToList();
    }

    public BancoModel ListarBancos(int CodigoUnico)
    {
        return _Banco.Banco.FirstOrDefault(x => x.CodigoBanco == CodigoUnico);
    }

}
