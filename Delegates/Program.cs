using Services;
namespace Delegates;
//Criando a delegate do tipo void, pois meus metodos são do tipo void
delegate void BinaryNumericOperation(double n1, double n2);
class Program
{
    public static void  Main(string[] args)
    {
        //iniciando as variaveis fixas
        double a = 10;
        double b =12;
        //atribuido meus metodos ao delagate
        BinaryNumericOperation op = CalculationService.ShowSum;
        //acrescentando outro metodo ao mesmo delegate com o +=
        op += CalculationService.ShowMax;
        //Invocando os metodos e atribuindo os valores fixos
        op.Invoke(a,b);
    }
}
