using Vitor.Models;

namespace Vitor;

public class Calculos
{
    public static void Calcular()
    {
        Folha.SB = Folha.Quantidade * Folha.Valor;
        if (Folha.SB <= 1903.98)
        {
            Folha.IR = 0;
        }
        else if (Folha.SB >=1903.99 || Folha.SB<=2826.65){
            Folha.IR = 142.80;
        } else if(Folha.SB >= 2826.66 || Folha.SB <=3751.05){
            Folha.IR = 354.80;
        }else if(Folha.SB >= 3751.06 || Folha.SB <= 4664.68){
            Folha.IR = 636.13;
        }else{
            Folha.IR = 869.36;
    }
    if(Folha.SB <=1693.72){
        Folha.INSS = Folha.SB * 0.08;
    }else if(Folha.SB >=1693.72 || Folha.SB <=2822.90){
        Folha.INSS = Folha.SB * 0.09;
    }else if(Folha.SB >=2822.91 || Folha.SB <= 5645.80){
        Folha.INSS = Folha.SB * 0.11;
    } else{
        Folha.INSS = 621.06;
    }
   
   Folha.FGTS = Folha.SB * 0.08;

   Folha.SL = Folha.SB - Folha.INSS ;
   Folha.SL = Folha.SB - Folha.IR;
   Folha.SL = Folha.SB - Folha.FGTS;
}
}
