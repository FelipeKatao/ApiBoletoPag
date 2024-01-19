using System.ComponentModel;
using ApiPag.Model;
using ApiPag.Service.Interface;

namespace ApiPag.Dominio.Boletos;

public class BoletoDominio
{
    private readonly IBoletoService _BoletoService;
    private readonly IBancoService _banco;
    public BoletoDominio(IBoletoService BoletoService,IBancoService bancoService)
    {
        _BoletoService = BoletoService;
        _banco = bancoService;
    }

    public BoletoModel CriarBoleto(BoletoModel boleto)
    {
        BoletoModel Boletos = _BoletoService.CriarNovoBoleto(boleto);
        return Boletos;
    }
    public BoletoModel BuscarBoleto(int BoletoId)
    {
        BoletoModel Boleto_corrente = _BoletoService.BuscarBoleto(BoletoId);
        DateTime DataBoleto = Boleto_corrente.Vencimento;
        if(DateTime.Now.Date >= DataBoleto.Date)
        {
            BancoModel Banco = _banco.ListarBancoId(Boleto_corrente.BancoId);
            decimal ValorCorrigidoJuros = Boleto_corrente.ValorBoleto*Banco.PercentualJuros;
            Boleto_corrente.ValorBoleto += ValorCorrigidoJuros;
        }
       return _BoletoService.BuscarBoleto(BoletoId);
    }

    public List<BoletoModel> BuscarTodosBoletos()
    {
       return _BoletoService.BuscarTodosBoletos();
    }
}
