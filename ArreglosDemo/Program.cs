
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

void CalcularMayorNotasCompleto()
{ 
int[] notasMatematica = { 16, 18, 14, 20 };
int[] notasLenguaje = { 16, 18, 14 };
int[] notasHistoria = { 18, 14 };

//Matemática
Console.WriteLine(CalcularMayorNotas(notasMatematica));
//Lenguaje
Console.WriteLine(CalcularMayorNotas(notasLenguaje));
//Historia
Console.WriteLine(CalcularMayorNotas(notasHistoria));

}

void ArreglosString()
{
    string[] nombres = { "Juan", "María", "Luis", "Ana" };

    for (int i = 0; i < nombres.Length; i++)
    {
        Console.WriteLine(nombres[i]);
    }

    string[] paises = new string[3];
    paises[0] = "Perú";
    paises[1] = "Argentina";
    paises[2] = "Colombia";

    for (int i = 0; i < paises.Length; i++)
    {
        Console.WriteLine(paises[i]);
    }
}

double[] IngresarSueldos(double[] sueldos)
{
    for (int i = 0; i < sueldos.Length; i++)
    {
        Console.WriteLine("Ingrese el sueldo " + (i + 1) + " :");
        sueldos[i] = Convert.ToDouble(Console.ReadLine());
    }
    return sueldos;
}

double CalcularPromedio(double[] sueldos)
{
    double promedio = 0;
    double sumaSueldos = 0;

    for (int i = 0; i < sueldos.Length; i++)
    {
        sumaSueldos = sumaSueldos + sueldos[i];

    }
    promedio=sumaSueldos/sueldos.Length;
    return promedio;
}

void CalcularPromedioCompleto()
{
    double[] sueldos = new double[5];
    double promedio = 0;
    sueldos = IngresarSueldos(sueldos);
    promedio = CalcularPromedio(sueldos);

    Console.WriteLine("El sueldo promedio es:");
    Console.WriteLine(promedio);

}


int[] IngresarNotas(int[] notas)
{
    for (int i = 0; i < notas.Length; i++)
    {
        Console.WriteLine("Ingrese la nota " + (i + 1) + " :");
        notas[i] = Convert.ToInt32(Console.ReadLine());
    }
    return notas;
}

int CalcularMenorNotas(int[] notas)
{
    int menor = notas[0];

    for (int i = 0; i < notas.Length; i++)
    {
        if (notas[i] < menor)
            menor = notas[i];
    }
    return menor;

}

double CalcularPromedioAjustadoNotas(int[] notas)
{
    double promedio;
    int menor = CalcularMenorNotas(notas);
    int mayor = CalcularMayorNotas(notas);
  
    int suma = 0;
    int cantidad = notas.Length - 2;
    for (int i = 0; i < notas.Length; i++)
    {
        suma = suma + notas[i];
    }

    promedio = (suma - mayor - menor) / cantidad;    

    return promedio;
}



void CalcularPromedioNotasCompleto()
{
    int cantidadNotas = 0;
    double promedioAjustado = 0;
    Console.WriteLine("Ingrese Cantidad Notas");
    cantidadNotas = Convert.ToInt32(Console.ReadLine());
    int[] notas = new int[cantidadNotas];
    IngresarNotas(notas);
    promedioAjustado = CalcularPromedioAjustadoNotas(notas);
    Console.WriteLine("El promedio es:");
    Console.WriteLine(promedioAjustado);
}

void EjemploArregloDidimensional()
{     
// Declarar e inicializar un arreglo bidimensional
int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine(i + "," + j);
        Console.WriteLine(matriz[i, j] + " ");

    }
    Console.WriteLine();
}
}
Console.ReadLine();






