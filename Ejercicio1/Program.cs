//ejercicio 1
internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Ingrese primer numero: ");
        int num1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Ingrese segundo numero: ");
        int num2=int.Parse(Console.ReadLine());
        if(num1>num2)
        {
            System.Console.WriteLine("El numero mayor es: "+ num1);
        }
        else
        {
            System.Console.WriteLine("El numero mayor es: "+ num2);
        }
    }
}