//ejercicio 7
internal class Program
{
    private static void Main(string[] args)
    {
        String Respuesta;
        do
        {
        System.Console.WriteLine("Ingrese primer lado: ");
        int lado1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Ingrese segundo lado: ");
        int lado2=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Ingrese tercer lado: ");
        int lado3=int.Parse(Console.ReadLine());
        if(lado1==lado2 && lado1==lado3)
        {
            System.Console.WriteLine("Equilatero");
        }
        else if(lado1==lado2 || lado1==lado3 || lado2==lado3)
        {
            System.Console.WriteLine("Isosceles");
        }
        else
        {
            System.Console.WriteLine("Escaleno");
        }
        System.Console.WriteLine("Desea Continuar(S/N)? ");
        Respuesta=Console.ReadLine();
        }while(Respuesta!="N" && Respuesta!="n");
    }
}
