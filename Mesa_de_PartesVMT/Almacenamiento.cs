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
        if (!File.Exists(ARCHIVO)) return;

        string[] lineas = File.ReadAllLines(ARCHIVO);
        contador = 0;

        foreach (string linea in lineas)
        {
            if (contador >= 100) break;

            string[] campos = linea.Split('|');
            if (campos.Length == 5)
            {
                codigos[contador] = campos[0];
                dnis[contador] = campos[1];
                nombres[contador] = campos[2];
                direcciones[contador] = campos[3];
                razones[contador] = campos[4];
                contador++;
            }
        }
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