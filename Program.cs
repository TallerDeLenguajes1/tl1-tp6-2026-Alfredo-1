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
            result = result * 10 + digito;
            numero /= 10;

            // Control de overflow
            if (result > int.MaxValue)
            if (result > int.MaxValue)
                numero=0;
        }
        Console.WriteLine("valor de numero invertido: "+result);
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
Console.WriteLine("\n===Fin del programa CalculadoraV1===\n");

//=====================================================================================================================================================
float numOp, vAbsoluto;
double cuadrado, raiz, sen, cos, enteroPuro;
int pNum, sNum;
do
    Console.WriteLine("ingrese un numero:");
while(!float.TryParse(Console.ReadLine(), out numOp));

vAbsoluto = Math.Abs(numOp);
cuadrado = Math.Pow(numOp,2);
sen= Math.Sin(numOp);
cos = Math.Cos(numOp);
enteroPuro = (int)numOp;
if (numOp >= 0)
{
    raiz = Math.Sqrt(numOp);
    Console.WriteLine($"El numero ingresado es: {numOp}\n\n|{numOp}|= {vAbsoluto}\nPotencia de ({numOp})= {cuadrado}\nRaiz de'{numOp}'= {raiz}\nSen({numOp})={sen}\nCos({numOp})= {cos}\nParte entera: {enteroPuro}\n");
}
else
{
    Console.WriteLine("\nNo se puede calcular la Raiz de este numero.\n");
    Console.WriteLine($"El numero ingresado es: {numOp}\n\n|{numOp}|= {vAbsoluto}\nPotencia de '{numOp}'= {cuadrado}\nSen({numOp})={sen}\nCos({numOp})= {cos}\nParte entera: {enteroPuro}\n");
}

Console.WriteLine("\n--ingrese dos numeros---\n\n");
do
    Console.WriteLine("Primer Numero:");
while(!int.TryParse(Console.ReadLine(), out pNum));
        
do
    Console.WriteLine("Segundo Numero:");
while(!int.TryParse(Console.ReadLine(), out sNum));
if (pNum>sNum)
{
    Console.WriteLine($"\nEl numero '{pNum}' es el mayor");
}else if(pNum<sNum)
{
    Console.WriteLine($"\nEl numero '{sNum}' es el mayor");
}else
    Console.WriteLine("\nLos numeros ingresador son iguales");

Console.WriteLine("\n---Fin del programa CalculadoraV2---\n");