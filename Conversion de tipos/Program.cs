//Convertir Entero a Decimal

Console.Write("Ingrese un numero entero: ");
int num80 = Convert.ToInt32(Console.ReadLine());
decimal total78 = Convert.ToDecimal(num80);
Console.Write("Ingrese un numero decimal: ");
decimal num20 = Convert.ToDecimal(Console.ReadLine());
decimal num30 = num20 + total78;
Console.WriteLine("El numero convertido a entero es: " + total78);
Console.WriteLine("Y sumado con un decimal es: " + num30);

//Decimal a Float

decimal num54 = 5.9999999m;
float num26 = (float)num54;
Console.WriteLine(num26);

//Convertir un Float a entero

float num14 = 5.56f;
Console.WriteLine("El numero es: " + num14);
int num28 = Convert.ToInt32(num14);
Console.WriteLine("El numero ahora es: " + num28);

//Convertir caracter a entero 

char num16 = 'B';
int num22 = Convert.ToInt32(num16);
Console.WriteLine(num22);

//Converitr entero a caracter

int num1 = 65;
char num2 = (char)num1;
Console.WriteLine("El caracter de " + num1 + " en ASCII es: " + num2);






