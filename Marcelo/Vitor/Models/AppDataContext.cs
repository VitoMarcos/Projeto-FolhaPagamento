using Microsoft.EntityFrameworkCore;
namespace Vitor.Models;

public class AppDataContext : DbContext
{

public DbSet<Funcionario> tabFuncionario { get; set; }
public DbSet<Folha> tabFolha { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       
        optionsBuilder.UseSqlite("Data Source=Marcelo_Vitor.db");
    }



}
