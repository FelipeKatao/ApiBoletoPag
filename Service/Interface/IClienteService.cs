using ApiPag.Model;

namespace ApiPag.Service.Interface;

public interface IClienteService
{
    List<ClienteModel> BuscarTodoUsuarios();
    ClienteModel CriarCliente(ClienteModel cliente);

    public ClienteModel BuscarClienteId(int id);
}
