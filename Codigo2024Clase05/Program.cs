
void LeerNota()
{
    int nota = 0;
    do
    {
        Console.Write("Ingresa una nota válida: ");
        nota = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine(nota < 0);
        Console.WriteLine(nota > 20);


    } while (nota < 0 || nota > 20);

    Console.WriteLine("Has ingresado nota: " + nota);
}
void EjemploMenu()
{
    string opcion;

    do
    {
        Console.WriteLine("Ingresa una de las siguientes opciones");
        Console.WriteLine("A) Mensaje de Bievenida");
        Console.WriteLine("B) Mensaje de Desepedida");
        Console.WriteLine("S) Salir");
        opcion = Console.ReadLine().ToUpper();


        switch (opcion)
        {
            case "A":
                Console.WriteLine("Ud. es Bienvenido");
                break;

            case "B":
                Console.WriteLine("Buenas noches hasta mañana");
                break;

            default:
                break;
        }

        Console.WriteLine("==============================");
        Console.WriteLine("==============================");

    } while (opcion != "S");


}

int CalcularMayorde4Notas(int nota1,int nota2, int nota3,int nota4)
{
    int mayor = nota1;    
    if (nota2 > mayor)
        mayor = nota2;
    if (nota3 > mayor)
        mayor = nota3;
    if (nota4 > mayor)
        mayor = nota4;
    return mayor;
}

int CalcularMayorde3Notas(int nota1, int nota2, int nota3)
{
    int mayor = nota1;
    if (nota2 > mayor)
        mayor = nota2;
    if (nota3 > mayor)
        mayor = nota3;
    if (nota3 > mayor)
        mayor = nota3;
    return mayor;
}
int CalcularMayorde2Notas(int nota1, int nota2)
{
    int mayor = nota1;
    if (nota2 > mayor)
        mayor = nota2;    
    return mayor;
}


//Matemática
Console.WriteLine(CalcularMayorde4Notas(16,18,14,20));
Console.WriteLine(CalcularMayorde4Notas(16, 15, 14, 10));
Console.WriteLine(CalcularMayorde4Notas(16, 17, 18, 12));

//Lenguaje
Console.WriteLine(CalcularMayorde3Notas(16, 18, 14));
Console.WriteLine(CalcularMayorde3Notas(16, 15, 14));
Console.WriteLine(CalcularMayorde3Notas(16, 17, 18));

//Historia
Console.WriteLine(CalcularMayorde2Notas(16, 18));
Console.WriteLine(CalcularMayorde2Notas(16, 15));
Console.WriteLine(CalcularMayorde2Notas(16, 17));





//int nota1;
//int nota2;
//int nota3;
//int nota4;
//int mayor;

//Console.WriteLine("Ingrese la nota 1");
//nota1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Ingrese la nota 2");
//nota2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Ingrese la nota 3");
//nota3 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Ingrese la nota 3");
//nota4 = Convert.ToInt32(Console.ReadLine());

//Calcular la nota mayor
//Console.WriteLine("La nota mayor es:");
//Console.WriteLine( CalcularMayorde3Notas(nota1,nota2,nota3,nota4));



Console.WriteLine("Gracias por Terminar");
Console.Read();
