//Suma de enteros

Console.Write("Ingrese un número entero para sumar: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingrese un segundo número entero para sumar: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int sum = num1 + num2; 
Console.WriteLine("El resultado de la sumas es: " + sum);

//Resta de decimales

Console.Write("Ingrese un número decimal para restar: ");
decimal num3 = Convert.ToDecimal(Console.ReadLine());
Console.Write("Ingrese un segundo número decimal para restar: ");
decimal num4  = Convert.ToDecimal(Console.ReadLine());
decimal rest = num3 - num4;
Console.WriteLine("El resultado de la resta es: " + rest);

//Multiplicacion de tipo Float

Console.Write("Ingrese un número tipo Float para multiplicar: ");
float num5 = Convert.ToSingle(Console.ReadLine());
Console.Write("Ingrese un segundo número tipo Float para multiplicar: ");
float num6 = Convert.ToSingle(Console.ReadLine());
float multi = num5 * num6;
Console.WriteLine("El resultado de la multiplicaicon es: " + multi);

//División de enteros

Console.Write("Ingrese un número entero para dividir: ");
int num7 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingrese un segundo número entero para dividir: ");
int num8 = Convert.ToInt32(Console.ReadLine());
int divi = num7 / num8;
Console.WriteLine("El resultado de la división es: " + divi);

//Modulo de enteros

Console.Write("Ingres un número para dividir y saber el modulo: ");
int num9 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingrese un segundo número para dividir: ");
int num10 = Convert.ToInt32(Console.ReadLine());
int modulo = num9 % num10;
Console.Write("El modulo de la división es: " + modulo);