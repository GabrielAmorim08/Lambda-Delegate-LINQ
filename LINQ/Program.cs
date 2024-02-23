using System.Linq;
class Program
{
    public static void Main(string[] args)
    {
        //Specify the data source
        int[] numbers = new int[] {2,3,4,5};

        //define the query expression
        var result = numbers.Where(x => x%2 == 0).Select(x => x*10);
        
        //Execute the query
        foreach (int x in result)
        {
            System.Console.WriteLine(x);
        }
    }
}