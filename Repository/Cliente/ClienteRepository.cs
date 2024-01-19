using ApiPag.Data.Boleto_Dados;
using ApiPag.Dominio.Cliente;
using ApiPag.Model;
using ApiPag.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace ApiPag.Repository.Cliente;

public class ClienteRepository : ICliente
{
    private readonly ClienteContext _Cliente;
    private readonly BoletosContext _Boletos;
    public ClienteRepository(ClienteContext clienteContext,BoletosContext boleto)
    {
        // Criar aqui o sistema de usuarios
        _Cliente = clienteContext;
        _Boletos = boleto;
    }

    public ClienteModel Adicionarcliente(ClienteModel Usuario)
    {
        _Cliente.Cliente.Add(Usuario);
        _Cliente.SaveChanges();

        return Usuario;
    }

    public List<ClienteModel> BuscarTodosUsuarios()
    {
        return _Cliente.Cliente.ToList();
    }

    public ClienteModel BuscarClienteId(int id){
        return _Cliente.Cliente.FirstOrDefault(x => x.Id == id);
    }



}
