using System;

class Program
{
    static string[] codigos = new string[2];
    static string[] dnis = new string[2];
    static string[] nombres = new string[2];
    static string[] direcciones = new string[2];
    static string[] razones = new string[2];

    static int contador = 0;

    static void RegistrarExpediente()
    {
        if (contador >= 2)
        {
            Console.WriteLine("No hay espacio disponible.");
            return;
        }

        string dni;

        do
        {
            Console.Write("Ingrese DNI (8 dígitos): ");
            dni = Console.ReadLine() ?? "";
        }
        while (dni.Length != 8);

        dnis[contador] = dni;

        Console.Write("Nombres y apellidos: ");
        nombres[contador] = Console.ReadLine() ?? "";

        Console.Write("Dirección: ");
        direcciones[contador] = Console.ReadLine() ?? "";

        Console.Write("Razón del trámite: ");
        razones[contador] = Console.ReadLine() ?? "";

        codigos[contador] = "EXP-" + (1000 + contador + 1);

        Console.WriteLine(
            "Registro exitoso. Código: " + codigos[contador]);

        contador++;
    }
static void OrdenarExpedientes()
{
    if (contador == 0)
    {
        Console.WriteLine("No hay expedientes registrados.");
        return;
    }

    string aux;

    // Ordenamiento burbuja por código
    for (int i = 0; i < contador - 1; i++)
    {
        for (int j = 0; j < contador - i - 1; j++)
        {
            if (string.Compare(codigos[j], codigos[j + 1],
                StringComparison.Ordinal) > 0)
            {
                // Intercambiar códigos
                aux = codigos[j];
                codigos[j] = codigos[j + 1];
                codigos[j + 1] = aux;

                // Intercambiar DNI
                aux = dnis[j];
                dnis[j] = dnis[j + 1];
                dnis[j + 1] = aux;

                // Intercambiar nombres
                aux = nombres[j];
                nombres[j] = nombres[j + 1];
                nombres[j + 1] = aux;

                // Intercambiar direcciones
                aux = direcciones[j];
                direcciones[j] = direcciones[j + 1];
                direcciones[j + 1] = aux;

                // Intercambiar razones
                aux = razones[j];
                razones[j] = razones[j + 1];
                razones[j + 1] = aux;
            }
        }
    }

    Console.WriteLine("\n=== EXPEDIENTES ORDENADOS ===");
    Console.WriteLine("-----------------------------------------------");

    for (int i = 0; i < contador; i++)
    {
        Console.WriteLine("Código: " + codigos[i]);
        Console.WriteLine("DNI: " + dnis[i]);
        Console.WriteLine("Solicitante: " + nombres[i]);
        Console.WriteLine("Dirección: " + direcciones[i]);
        Console.WriteLine("Razón del trámite: " + razones[i]);
        Console.WriteLine("-----------------------------------------------");
    }
}