//ejercicio 10
internal class Program
{
    private static void Main(string[] args)
    {
       int fac=1,x,n;
            String linea;
            x = 1;
            Console.Write("Ingrese un numero: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            while (x <= n)
            {
                fac = fac * x;
                x = x + 1;
            }
            Console.Write("La factorial es: "+fac);
    }
}