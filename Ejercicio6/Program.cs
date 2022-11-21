//ejercicio 6
internal class Program
{
    private static void Main(string[] args)
    {
        int num=0, suma=0;
        do
        {
             System.Console.WriteLine("Ingrese un numero: ");
             num=int.Parse(Console.ReadLine());
             suma=suma+num;
        }while(num!=0);
        System.Console.WriteLine("La suma de los numeros ingresados es: "+suma);
    }
}