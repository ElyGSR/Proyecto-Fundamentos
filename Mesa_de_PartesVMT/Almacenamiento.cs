using System;
using System.IO;

namespace Mesa_de_PartesVMT;

public static class Almacenamiento
{
    private static readonly string ARCHIVO =
        Path.Combine(AppContext.BaseDirectory, "expedientes_vmt.txt");

    public static void CargarDatos(string[] codigos, string[] dnis,
        string[] nombres, string[] direcciones, string[] razones, ref int contador)
    {
        // TODO: etapa 2
    }

    public static void GuardarDatos(string[] codigos, string[] dnis,
        string[] nombres, string[] direcciones, string[] razones, int contador)
    {
        string[] lineas = new string[contador];

        for (int i = 0; i < contador; i++)
        {
            lineas[i] = codigos[i] + "|" + dnis[i] + "|" + nombres[i] + "|" +
                        direcciones[i] + "|" + razones[i];
        }

        File.WriteAllLines(ARCHIVO, lineas);
        Console.WriteLine($"Datos guardados: {contador} expediente(s).");
    }
}