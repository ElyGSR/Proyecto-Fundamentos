namespace Mesa_de_PartesVMT
{
    public class Ordenamiento
    {
        public static void OrdenarExpedientes(string[] codigos, DateTime[] fechas, string[] nombres, string[] razones)
        {
            Console.WriteLine("ORDENAR EXPEDIENTES");

            for (int i = 0; i < fechas.Length - 1; i++)
            {
                for (int j = 0; j < fechas.Length - i - 1; j++)
                {
                    if (fechas[j] > fechas[j + 1])
                    {
                        DateTime tempFecha = fechas[j];
                        fechas[j] = fechas[j + 1];
                        fechas[j + 1] = tempFecha;

                        string tempNombre = nombres[j];
                        nombres[j] = nombres[j + 1];
                        nombres[j + 1] = tempNombre;

                        string tempRazon = razones[j];
                        razones[j] = razones[j + 1];
                        razones[j + 1] = tempRazon;
                    }
                }
            }
        }

        internal static void OrdenarExpedientes(string[] codigos, string[] dnis, string[] nombres, string[] direcciones, string[] razones, int contador)
        {
            throw new NotImplementedException();
        }

    }
}