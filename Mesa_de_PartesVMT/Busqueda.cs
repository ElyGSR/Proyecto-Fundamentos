using System;
namespace Mesa_de_PartesVMT;
public static class Busqueda
{
    public static void BuscarExpediente(
        string[] codigos,
        string[] documentos,
        string[] tiposDocumentos,
        string[] nombres,
        string[] direcciones,
        string[] razones,
        int contador)
    {
        Console.WriteLine("BUSQUEDA DE EXPEDIENTE");
        if (contador == 0)
        {
            Console.WriteLine("No hay expedientes registrados.");
            return;
        }
        Console.Write("Ingrese el codigo del expediente: ");
        string buscar = (Console.ReadLine() ?? "").Trim();
        if (string.IsNullOrWhiteSpace(buscar))
        {
            Console.WriteLine("Debe ingresar un codigo de expediente.");
            return;
        }
        bool encontrado = false;
        for (int i = 0; i < contador; i++)
        {
            if (string.Equals(
                codigos[i],
                buscar,
                StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("EXPEDIENTE ENCONTRADO");
                Console.WriteLine($"Codigo: {codigos[i]}");
                Console.WriteLine($"Tipo de documento: {tiposDocumentos[i]}");
                Console.WriteLine($"Numero de documento: {documentos[i]}");
                Console.WriteLine($"Solicitante: {nombres[i]}");
                Console.WriteLine($"Direccion: {direcciones[i]}");
                Console.WriteLine($"Motivo de solicitud: {razones[i]}");
                encontrado = true;
                break;
            }
        }
        if (!encontrado)
        {
            Console.WriteLine();
            Console.WriteLine("No se encontro ningun expediente con ese codigo.");
            Console.WriteLine("Verifique el codigo e intentelo nuevamente.");
        }
    }
}
