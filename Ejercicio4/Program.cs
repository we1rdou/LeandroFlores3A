//ejercicio 4
internal class Program
{
    private static void Main(string[] args)
    {
        int num=0;
        do
        {
            System.Console.WriteLine("Ingrese un numero: ");
             num=int.Parse(Console.ReadLine());
        }while(num!=0);
    }
    }