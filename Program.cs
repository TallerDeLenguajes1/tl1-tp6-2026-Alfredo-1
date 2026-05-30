Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a: "+a);
Console.WriteLine("valor de b: "+b);

Console.WriteLine("ingrese un numero positivo: ");

if(int.TryParse(Console.ReadLine(), out int numero))
{
    if (numero > 0)
    {
        Console.WriteLine("valor de numero: "+numero);
        int resultado=0;
        while (numero > 0)
        {
            int digito = numero % 10;
            resultado = resultado * 10 + digito;
            numero /= 10;

            // Control de overflow
            if (resultado > int.MaxValue)
                numero=0;
        }
        Console.WriteLine("valor de numero invertido: "+resultado);
    }else
        Console.WriteLine("El numero debe ser mayor que 0");
}else
    Console.WriteLine("Entrada no valida");
