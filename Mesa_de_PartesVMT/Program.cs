using Mesa_de_PartesVMT;

Console.OutputEncoding = System.Text.Encoding.UTF8;

const int MAX = 100;   // para probar el mensaje "No hay espacio", bájalo a 5

string[] codigos = new string[MAX];
string[] dnis = new string[MAX];
string[] nombres = new string[MAX];
string[] direcciones = new string[MAX];
string[] razones = new string[MAX];
int contador = 0;
int opcion;

// Al iniciar: recupera los expedientes guardados antes
Almacenamiento.CargarDatos(codigos, dnis, nombres, direcciones, razones, ref contador);

do
{
    Console.WriteLine();
    Console.WriteLine("=== MESA DE PARTES DIGITAL - MUNICIPALIDAD DE VMT ===");
    Console.WriteLine("1. Registrar expediente");
    Console.WriteLine("2. Buscar expediente por código");
    Console.WriteLine("3. Ordenar y listar expedientes");
    Console.WriteLine("4. Guardar y salir");
    Console.Write("Seleccione una opción: ");

    if (!int.TryParse(Console.ReadLine(), out opcion))
    {
        opcion = 0;   // texto no numérico: cae en "opción no válida"
    }

    switch (opcion)
    {
        case 1:
            Registro.RegistrarExpediente(codigos, dnis, nombres, direcciones, razones, ref contador);
            break;
        case 2:
            Busqueda.BuscarExpediente(codigos, dnis, nombres, direcciones, razones, contador);
            break;
        case 3:
            Ordenamiento.OrdenarExpedientes(fechas, nombres, razones);
            break;
        case 4:
            Almacenamiento.GuardarDatos(codigos, dnis, nombres, direcciones, razones, contador);
            Console.WriteLine("Saliendo del sistema...");
            break;
        default:
            Console.WriteLine("Opción no válida. Ingrese un número del 1 al 4.");
            break;
    }
} while (opcion != 4);