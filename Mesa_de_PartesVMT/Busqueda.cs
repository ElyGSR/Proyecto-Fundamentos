using System;

namespace Mesa_de_PartesVMT
{
    public class Busqueda
    {
        public static void BuscarExpediente(string[] codigo, string[] descripcion, int total)
        {
            Console.WriteLine("=== BUSCAR EXPEDIENTE ===");
            Console.Write("Ingrese el codigo que desea buscar: ");
            string buscar = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(buscar))
            {
                Console.WriteLine("\n[!] Error: Debe ingresar un codigo valido.");
                return;
            }
            bool encontrado = false;
            for (int i = 0; i < total; i++)
            {
                if (codigo[i] != null && codigo[i].Equals(buscar.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\n¡Expediente encontrado!");
                    Console.WriteLine("Codigo: " + codigo[i]);
                    Console.WriteLine("Descripcion: " + descripcion[i]);
                    encontrado = true;
                    break;
                }
            }
            if (encontrado == false)
            {
                Console.WriteLine("\nNo se encontro ningun expediente con ese codigo.");
            }
        }
    }
}