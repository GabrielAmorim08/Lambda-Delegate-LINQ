namespace Services{

    class CalculationService
    {
        //metodo para mostrar o maior numero entre duas variaveis
        public static void ShowMax(double x, double y)
        {
            //fazendo um teste com o operador ternario
            double max = (x > y)  ? x : y;
            //mostrando o valor maximo na tela
            System.Console.WriteLine(max);
        }
        //metodo para mostrar a soma de duas variaveis
        public static void ShowSum(double x, double y)
        {
            //variavel que faz a soma
            double sum = x + y;
            //mostrando o valor da soma
            System.Console.WriteLine(sum);
        }

    }
}