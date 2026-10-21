using System;

namespace Mesa_de_PartesVMT
{
    public class Busqueda
    {
        public static void BuscarExpediente(
            string[] codigos,
            string[] dnis,
            string[] nombres,
            string[] direcciones,
            string[] razones,
            int contador)
        {
            Console.WriteLine();
            Console.WriteLine("=== BUSQUEDA DE EXPEDIENTE ===");
            Console.Write("Ingrese el codigo del expediente: ");
            string buscar = Console.ReadLine() ?? "";
            buscar = buscar.Trim();
            bool encontrado = false;
            for (int i = 0; i < contador; i++)
            {
                if (codigos[i] == buscar)
                {
                    Console.WriteLine("EXPEDIENTE ENCONTRADO");
                    Console.WriteLine("Codigo: " + codigos[i]);
                    Console.WriteLine("DNI: " + dnis[i]);
                    Console.WriteLine("Nombre: " + nombres[i]);
                    Console.WriteLine("Direccion: " + direcciones[i]);
                    Console.WriteLine("Razon: " + razones[i]);
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine(
                    "No se encontro ningun expediente con ese codigo."
                );
            }
        }
    }
}