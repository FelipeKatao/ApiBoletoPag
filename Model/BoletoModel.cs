namespace ApiPag.Model;

public class BoletoModel
{
    public int Id{get;set;}
    public string ?NomePagador {get;set;}
    public string ?CPF_Pagador {get;set;}
    public string ?CNPJ_pagador {get;set;}
    public string ?NomeBeneficiario {get;set;}
    public decimal ValorBoleto {get;set;}
    public DateTime Vencimento {get;set;}
    public string ?Observacao {get;set;}
    public int BancoId {get;set;}
    public int ClientId {get;set;}

}
