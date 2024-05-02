using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
namespace Vitor.Models;

public class Folha : Funcionario
{

    public Folha()
    {
        folhaId = Guid.NewGuid().ToString();

    }

    public Folha(double valor, int quantidade, int mes, int ano, double sb, double ir, double inss, double fgts, double sl, string nome, string cpf)
    {
        folhaId = Guid.NewGuid().ToString();

        Valor = valor;
        Quantidade = quantidade;
        Mes = mes;
        Ano = ano;
        SB = sb;
        IR = ir;
        INSS = inss;
        FGTS = fgts;
        SL = sl;
        Nome = nome;
        Cpf = cpf;
        funcionarioId = Guid.NewGuid().ToString();
    }


    public string? folhaId { get; set; }
    [Range(600.00, 1000000000, ErrorMessage = "Este campo deve ter valores a partir de R$600,00")]
    public static double Valor { get; set; }
    public static int Quantidade { get; set; }
    [MinLength(2, ErrorMessage = "Este campo tem o tamanho mínimo de 2 caracteres!")]
    [MaxLength(2, ErrorMessage = "Este campo tem o tamanho máximo de 2 caracteres!")]
    public int Mes { get; set; }
    [MinLength(4, ErrorMessage = "Este campo tem o tamanho mínimo de 4 caracteres!")]
    [MaxLength(4, ErrorMessage = "Este campo tem o tamanho máximo de 4 caracteres!")]
    public int Ano { get; set; }

    public static double SB {get;set;}  
    public static double IR {get;set;}  
    public static double INSS {get;set;}  
    public static double FGTS {get;set;}  
    public static double SL {get;set;}  

    
















}
