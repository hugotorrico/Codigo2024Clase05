
using System.ComponentModel.DataAnnotations;

void NotasSinArreglo()
{
    int nota1;
    int nota2;
    int nota3;
    int nota4;
    int nota5;
    int nota6;
    int nota7;
    int nota8;
    int nota9;
    int nota10;

    nota1 = 16;
    nota2 = 18;
    nota3 = 20;
    nota4 = 14;
    nota5 = 16;
    nota6 = 18;
    nota7 = 20;
    nota8 = 14;
    nota9 = 20;
    nota10 = 14;

    Console.WriteLine(nota1);
    Console.WriteLine(nota2);
    Console.WriteLine(nota3);
    Console.WriteLine(nota4);
    Console.WriteLine(nota5);
    Console.WriteLine(nota6);
    Console.WriteLine(nota7);
    Console.WriteLine(nota8);
    Console.WriteLine(nota9);
    Console.WriteLine(nota10);

}

void NotasArreglos()
{
    int[] notas = new int[10];
    notas[0] = 16;
    notas[1] = 18;
    notas[2] = 20;
    notas[3] = 14;
    notas[4] = 16;
    notas[5] = 18;
    notas[6] = 20;
    notas[7] = 14;
    notas[8] = 20;
    notas[9] = 14;

    for (int i = 0; i < notas.Length; i++)
    {
        Console.WriteLine(notas[i]);
    }


}

int CalcularMayorNotas(int[] notas)
{
    int mayor = notas[0];

    for (int i = 0; i < notas.Length; i++)
    {
        if (notas[i] > mayor)
            mayor = notas[i];
    }
    return mayor;

}

//int mayor = notas.Max();//Función es propia del .NET

int[] notasMatematica = { 16, 18, 14, 20 };
int[] notasLenguaje = { 16, 18, 14 };
int[] notasHistoria = { 18, 14 };
//Matemática
Console.WriteLine(CalcularMayorNotas(notasMatematica));
//Lenguaje
Console.WriteLine(CalcularMayorNotas(notasLenguaje));
//Historia
Console.WriteLine(CalcularMayorNotas(notasHistoria));


Console.ReadLine();






