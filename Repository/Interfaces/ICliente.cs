using ApiPag.Model;

namespace ApiPag.Repository.Interfaces;

public interface ICliente
{
    List<ClienteModel> BuscarTodosUsuarios();
    ClienteModel Adicionarcliente(ClienteModel Usuario);
    ClienteModel BuscarClienteId(int id);
}
