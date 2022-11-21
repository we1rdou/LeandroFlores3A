//ejercicio 5
internal class Program
{
    private static void Main(string[] args)
    {
        int suma=0;
        for(int x=0;x<8;x++)
        {
            System.Console.WriteLine("Ingrese numero: ");
            int num=int.Parse(Console.ReadLine());
            suma=suma+num;
        }
        System.Console.WriteLine("La suma de los numeros ingresados es: "+suma);
    }
}