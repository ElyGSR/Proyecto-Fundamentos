using System;

namespace Mesa_de_PartesVMT
{
    public class Ordenamiento
    {
        public static void OrdenarExpedientes(
            string[] codigos,
            string[] documentos,
            string[] tiposDocumentos,
            string[] nombres,
            string[] direcciones,
            string[] razones,
            int contador)
        {
            if (contador == 0)
            {
                Console.WriteLine("No hay expedientes registrados.");
                return;
            }

            string aux;


            for (int i = 0; i < contador - 1; i++)
            {
                for (int j = 0; j < contador - i - 1; j++)
                {
                    if (string.Compare(codigos[j], codigos[j + 1],
                        StringComparison.Ordinal) > 0)
                    {

                        aux = codigos[j];
                        codigos[j] = codigos[j + 1];
                        codigos[j + 1] = aux;

                        aux = documentos[j];
                        documentos[j] = documentos[j + 1];
                        documentos[j + 1] = aux;

                        aux = tiposDocumentos[j];
                        tiposDocumentos[j] = tiposDocumentos[j + 1];
                        tiposDocumentos[j + 1] = aux;

                        aux = nombres[j];
                        nombres[j] = nombres[j + 1];
                        nombres[j + 1] = aux;

                        aux = direcciones[j];
                        direcciones[j] = direcciones[j + 1];
                        direcciones[j + 1] = aux;

                        aux = razones[j];
                        razones[j] = razones[j + 1];
                        razones[j + 1] = aux;
                    }
                }
            }

            Console.WriteLine("=== EXPEDIENTES ORDENADOS ===");
            Console.WriteLine("-----------------------------------------------");

            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine("Código: " + codigos[i]);
                Console.WriteLine("Tipo de documento: " + tiposDocumentos[i]);
                Console.WriteLine("Número de documento: " + documentos[i]);
                Console.WriteLine("Solicitante: " + nombres[i]);
                Console.WriteLine("Dirección: " + direcciones[i]);
                Console.WriteLine("Razón del trámite: " + razones[i]);
            }
        }
    }
}