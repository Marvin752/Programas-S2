//Area de un triaungulo

Console.Write("Ingrese la base del triangulo: ");
decimal baset = Convert.ToDecimal(Console.ReadLine());
Console.Write("Ingrese la altura del triagunlo: ");
decimal alut = Convert.ToDecimal(Console.ReadLine());
decimal aret = (baset + alut) / 2;
Console.WriteLine("El area del triangulo es: "+ aret);

//Volumen de una esfera

Console.Write("Ingrese el radio de la esfera: ");
decimal esfr = Convert.ToDecimal(Console.ReadLine());
decimal pi = 3.1416m;
decimal esfv = 4/3 * pi * (esfr * esfr * esfr);
Console.WriteLine("El volumen de la esfera es: " + esfv);

//Distancia entre dos puntos

Console.Write("Ingrese las coordenadas en X del primer punto: ");
double puntx1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese las coordenadas en Y del primer punto: ");
double punty1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese las coordenadas en X del Segundo punto: ");
double puntx2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese las coordenadas en X del Segundo punto: ");
double punty2 = Convert.ToDouble(Console.ReadLine());
double disnt = Math.Sqrt(Math.Pow(puntx1 - puntx2, 2) + Math.Pow(punty1 - punty2, 2));
Console.WriteLine("La distancia que hay entre los puntos es: " + disnt);

//Celsius a Fahrenheit

Console.Write("Ingresa la temperatura en Celsius: ");
float gradc = Convert.ToSingle(Console.ReadLine());
float fare = (9f / 5f) * gradc + 32;
Console.WriteLine("La temperatura en Fahrenheit es: " + fare);

//Fahrenheit a Celsius

Console.Write("Ingrese la temperatura Fahrenheit: ");
float fare1 = Convert.ToSingle(Console.ReadLine());
float gradc1 = (fare1 - 32) / 1.8f;
Console.WriteLine("La temperatura en Celsius es: " + gradc1);