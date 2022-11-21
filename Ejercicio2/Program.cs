//ejercicio 2
internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Ingrese un numero: ");
        int num=int.Parse(Console.ReadLine());
        if(num%2==0)
        {
            System.Console.WriteLine("El numero ingresado es par");
        }
        else
        {
            System.Console.WriteLine("El numero ingresado es impar");
        }
    }
}