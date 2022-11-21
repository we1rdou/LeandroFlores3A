//ejercicio 3
internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Ingrese primer numero: ");
        int num1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Ingrese segundo numero: ");
         int num2=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Ingrese tercer numero: ");
         int num3=int.Parse(Console.ReadLine());
         if(num1>num2 && num1>num3)
         {
            System.Console.WriteLine("El numero mayor es: "+num1);
         }
         else if(num2>num3)
         {
            System.Console.WriteLine("El numero mayor es: "+num2);
         }
         else
         {
            System.Console.WriteLine("El numero mayor es: "+num3);
         }
    }
}