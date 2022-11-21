//ejercicio 9
internal class Program
{
    private static void Main(string[] args)
    {
        int cont=-1;
        double num=1,suma=0;
        while(num!=0)
        {
            System.Console.WriteLine("Ingrese un numero: ");
             num=double.Parse(Console.ReadLine());
             suma=suma+num;
             cont++;
        }
        System.Console.WriteLine("La media aritmetica es: " +suma/cont);
    }
}