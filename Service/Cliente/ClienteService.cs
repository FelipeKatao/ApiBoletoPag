using ApiPag.Dominio.Cliente;
using ApiPag.Model;
using ApiPag.Repository.Cliente;
using ApiPag.Repository.Interfaces;
using ApiPag.Service.Interface;

namespace ApiPag.Service.Cliente;

public class ClienteService : IClienteService
{

    private readonly ICliente _clientRepository;


    public ClienteService(ICliente clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public ClienteModel BuscarClienteId(int id)
    {
       return _clientRepository.BuscarClienteId(id);
    }

    public List<ClienteModel> BuscarTodoUsuarios()
    {
        return _clientRepository.BuscarTodosUsuarios();
    }

    public ClienteModel CriarCliente(ClienteModel cliente)
    {
        return _clientRepository.Adicionarcliente(cliente);
    }

}
