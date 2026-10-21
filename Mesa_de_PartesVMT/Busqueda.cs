using System;

namespace Mesa_de_PartesVMT
{
    public class Busqueda
    {
        public static void BuscarExpediente(string[] codigo, string[] descripcion, int total)
        {
            Console.WriteLine("BUSCAR EXPEDIENTE");
            Console.Write("Ingrese el codigo que desea buscar: ");
            string buscar = Console.ReadLine();
            bool encontrado = false;
            for (int i = 0; i < total; i++)
            {
                if (codigo[i] == buscar)
                {
                    Console.WriteLine("¡Expediente encontrado!");
                    Console.WriteLine("Codigo: " + codigo[i]);
                    Console.WriteLine("Descripcion: " + descripcion[i]);
                    encontrado = true;
                    break;
                }
            }
            if (encontrado == false)
            {
                Console.WriteLine("No se encontro ningun expediente con ese codigo.");
            }
        }

        internal static void BuscarExpediente(string[] codigos, string[] dnis, string[] nombres, string[] direcciones, string[] razones, int contador)
        {
            throw new NotImplementedException();
        }

    }
}