//Cambio a Mayusculas

Console.Write("Escriba una cadena de texto: ");
string cadena  = Console.ReadLine();
string cadenam = cadena.ToUpper();
Console.WriteLine("La cadena en mayusculas: " + cadenam);

//Cambio a Minisculas
Console.Write("Escriba una cadena de texto en MAYUSCULA: ");
string cadena1  = Console.ReadLine(); 
string cadenam1 = cadena1.ToLower();
Console.WriteLine("La cadena en minusculas: " + cadenam1);

//Imprimir al revez

Console.Write("Escriba una cadena de caracteres: ");
string cadena2 = Console.ReadLine();
string cadenam2 = "";
for (int i = cadena2.Length - 1; i >= 0; i--)
{
    cadenam2 += cadena2[i];
}
Console.WriteLine("El texto invertido es: " + cadenam2);

//Buscar palabra

Console.Write("Ingrese una oracion: ");
string cadena3 =  Console.ReadLine(); ;
Console.Write("Ingrese una palabra para buscar: ");
string cadenm3 =  Console.ReadLine();
int prubi = cadena3.IndexOf(cadenm3);
if(cadena3.Contains(cadenm3))
{
    
    Console.WriteLine("La palabra que ingreso se encuentra en la posición: " + prubi);
}
else
{
    Console.WriteLine("La palabra solicitada no se encuentra");
}

//Numero de bocales

Console.Write("Ingrese una paalabra para contar vocales: ");
string cadena4 = Console.ReadLine().ToLower();
int total = 0;
for (int i = cadena4.Length - 1; i >= 0; i--)
{
    if (cadena4[i] == 'a' || cadena4[i] == 'e' || cadena4[i] == 'i' || cadena4[i] == 'o' || cadena4[i] == 'u')
    {
        total++;
    }
}
Console.WriteLine("La palabra " + cadena4 + " Tiene " + total + " vocales");   
