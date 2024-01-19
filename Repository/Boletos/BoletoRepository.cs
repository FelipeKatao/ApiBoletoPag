using ApiPag.Data.Boleto_Dados;
using ApiPag.Model;
using ApiPag.Repository.Interfaces;

namespace ApiPag.Repository.Boletos;

public class BoletoRepository : IBoletos
{
    private readonly BoletosContext _Boleto;
    public BoletoRepository(BoletosContext boletosContext)
    {
        _Boleto = boletosContext;
    }

    public BoletoModel BuscaBoleto(int id)
    {
       return _Boleto.Boletos.FirstOrDefault(x => x.Id == id);
    }

    public IQueryable<object> BuscarBoletosCliente(int ClienteId)
    {
        return _Boleto.Boletos.Where(s => s.ClientId == ClienteId);
    }


    public List<BoletoModel> BuscarTodosBoletos()
    {
        return _Boleto.Boletos.ToList();
    }

    public BoletoModel CriarNovoBoleto(BoletoModel boleto)
    {
        _Boleto.Boletos.Add(boleto);
        _Boleto.SaveChanges();

        return boleto;
    }

}
