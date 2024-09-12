// See https://aka.ms/new-console-template for more information



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

//LeerNota();

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

} while (opcion!="S");



Console.WriteLine("Gracias por Terminar");
Console.Read();
