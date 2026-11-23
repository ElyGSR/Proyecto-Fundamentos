using System;
using System.IO;

namespace Mesa_de_PartesVMT;

public static class Almacenamiento
{
    private static readonly string ARCHIVO =
        Path.Combine(AppContext.BaseDirectory, "expedientes_vmt.txt");

    public static void CargarDatos(string[] codigos, string[] documentos, string[] tiposDocumentos,
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
                documentos[contador] = campos[1];
                tiposDocumentos[contador] = campos[2];
                nombres[contador] = campos[3];
                direcciones[contador] = campos[4];
                razones[contador] = campos[5];
                contador++;
            }
        }
    }

    public static void GuardarDatos(string[] codigos, string[] documentos, string[] tiposDocumentos, string[] nombres, string[] direcciones, string[] razones, int contador)
    {
        string[] lineas = new string[contador];

        for (int i = 0; i < contador; i++)
        {
            lineas[i] = codigos[i] + "|" + documentos[i] + "|" + tiposDocumentos[i] + "|" +
                        direcciones[i] + "|" + razones[i];
        }

        File.WriteAllLines(ARCHIVO, lineas);
        Console.WriteLine($"Datos guardados: {contador} expediente(s).");
    }
}