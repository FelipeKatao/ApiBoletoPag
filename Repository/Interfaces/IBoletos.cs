using ApiPag.Model;

namespace ApiPag.Repository.Interfaces;

public interface IBoletos
{
    BoletoModel CriarNovoBoleto(BoletoModel boleto);
    List<BoletoModel> BuscarTodosBoletos();
    BoletoModel BuscaBoleto(int id);
    IQueryable<object>  BuscarBoletosCliente(int ClienteId);
}
