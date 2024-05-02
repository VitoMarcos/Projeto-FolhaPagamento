using System.ComponentModel.DataAnnotations;

namespace Vitor.Models;

public class Funcionario
{

    public Funcionario(){
        funcionarioId = Guid.NewGuid().ToString();
    }

    public Funcionario(string nome, string cpf){
        funcionarioId = Guid.NewGuid().ToString();
        Nome = nome;
        Cpf = cpf;
    }



    public string funcionarioId {get; set;}
    [Required(ErrorMessage = "Este campo é obrigatório!")]
    public string? Nome {get; set;}
    [Required(ErrorMessage = "Este campo é obrigatório!")]
    [MinLength(11, ErrorMessage = "O cpf deve ter 11 digitos!")]
    
    public string? Cpf {get; set;}


}
