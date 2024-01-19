using ApiPag.Model;

namespace ApiPag.Service.Interface;

public interface IBoletoService
{
    BoletoModel CriarNovoBoleto(BoletoModel boleto);
    List<BoletoModel> BuscarTodosBoletos();
    BoletoModel BuscarBoleto(int id);
    IQueryable<object> BuscarBoletosCliente(int ClientId);
}
