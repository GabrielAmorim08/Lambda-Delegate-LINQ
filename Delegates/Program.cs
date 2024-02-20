using Services;
namespace Delegates;
delegate double BinaryNumericOperation(double n1, double n2);
class Program
{
    public void  Main(string[] args)
    {
        double a = 10;
        double b =12;
        BinaryNumericOperation op = CalculationService.Sum;
        BinaryNumericOperation opOtherSintax= new BinaryNumericOperation(CalculationService.Max);
         
        double result = op.Invoke(a,b);
        System.Console.WriteLine(result);
    }
}
