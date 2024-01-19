using System.Collections;
using ApiPag.Model;
using ApiPag.Service.Cliente;
using ApiPag.Service.Interface;

namespace ApiPag.Dominio.Cliente;

public class ClienteDominio
{
    private readonly IClienteService _ClienteService;
    private readonly IBoletoService _BoletoService;

    public ClienteDominio(IClienteService clienteService,IBoletoService boleto)
    {
        _ClienteService = clienteService;
        _BoletoService = boleto;
    }


    public List<ClienteModel> ListarTodosUsuarios()
    {
        List<ClienteModel> Clientes = _ClienteService.BuscarTodoUsuarios();
        return Clientes;
    }
    public ClienteModel CriarNovocliente(ClienteModel clienteNovo)
    {
        return _ClienteService.CriarCliente(clienteNovo);
    }
    public ArrayList ClientePagamento(int ClienteId)
    {
        ClienteModel Cliente = _ClienteService.BuscarClienteId(ClienteId);
        if(Cliente == null)
        {
            return new(){};
        }
        IQueryable<Object> Boleto = _BoletoService.BuscarBoletosCliente(ClienteId);
        ArrayList Pagamento = new() { Cliente,Boleto};

        return Pagamento;

    }
}
