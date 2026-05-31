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
        int result=0;
        while (numero > 0)
        {
            int digito = numero % 10;
            result = result * 10 + digito;
            numero /= 10;

            // Control de overflow
            if (result > int.MaxValue)
                numero=0;
        }
        Console.WriteLine("valor de numero invertido: "+result);
    }else
        Console.WriteLine("El numero debe ser mayor que 0");
}else
    Console.WriteLine("Entrada no valida");
//==========================================================================================================
 int condicion=0, operacion;
 float resultado, numero1, numero2;
 char letra;
do
{
    Console.WriteLine("\n----CALCULADORA----\n\n");
    Console.WriteLine("1.---Sumar---");
    Console.WriteLine("2.---Restar---");
    Console.WriteLine("3.---Multiplicar--");
    Console.WriteLine("4.---Dividir---");
    Console.WriteLine("\nIngrese una opcion: ");
    if(int.TryParse(Console.ReadLine(), out operacion) && operacion > 0 && operacion <= 4)
    {   
        do
            Console.WriteLine("primer numero: ");
        while(!float.TryParse(Console.ReadLine(), out numero1));
        do
            Console.WriteLine("segundo numero: ");
        while(!float.TryParse(Console.ReadLine(), out numero2));

        switch (operacion)
        {
            case 1:
                resultado = numero1 + numero2;
                Console.WriteLine("Resultado: "+resultado);
            break;
            case 2:
                resultado = numero1 - numero2;
                Console.WriteLine("Resultado: "+resultado);
            break;
            case 3:
                resultado = numero1 * numero2;
                Console.WriteLine("Resultado: "+resultado);
            break;
            case 4:
                resultado = numero1 / numero2;
                Console.WriteLine("Resultado: "+resultado);
            break;
            default:
            break;
        }
        Console.WriteLine("\nSi desea realizar otra operacion ingrese la letra 'y'");
        if(!char.TryParse(Console.ReadLine(),out letra) || letra !='y')
            condicion = 1;
    }
    else
        Console.WriteLine("Entrada incorrecta\n");
}while(condicion != 1);
Console.WriteLine("\n===Fin del programa===\n");