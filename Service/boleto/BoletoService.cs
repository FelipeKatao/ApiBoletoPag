using ApiPag.Model;
using ApiPag.Repository.Interfaces;
using ApiPag.Service.Interface;

namespace ApiPag.Service.boleto;

public class BoletoService : IBoletoService
{
    private readonly IBoletos _boletoRepository;

    public BoletoService(IBoletos boletos)
    {
        _boletoRepository = boletos;
    }


    public BoletoModel BuscarBoleto(int id)
    {
        return _boletoRepository.BuscaBoleto(id);
    }

    public IQueryable<object> BuscarBoletosCliente(int ClientId)
    {
        return _boletoRepository.BuscarBoletosCliente(ClientId);
    }


    public List<BoletoModel> BuscarTodosBoletos()
    {
        return _boletoRepository.BuscarTodosBoletos();
    }

    public BoletoModel CriarNovoBoleto(BoletoModel boleto)
    {
        return _boletoRepository.CriarNovoBoleto(boleto);
    }
}
