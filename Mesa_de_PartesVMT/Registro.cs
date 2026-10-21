namespace Mesa_de_PartesVMT; 

  public static class Registro
{
    public static void RegistrarExpediente(
         string[]codigos,
         string[]dnis, 
         string[]nombres,
         string[]direcciones,
         string[]razones, 
         ref int contador)
    {
        if(contador >= codigos.Length)
        {
            System.Console.WriteLine("No hay espacio disponible");
            return; 
        }
        System.Console.WriteLine("Ingrese DNI del solicitante");
        string dni = Console.ReadLine()?? ""; 
        while(!Validar_Expediente.ValidarDNI(dni))
        {
            System.Console.WriteLine("El DNI es incorrecto, Debe tener 8 digitos");
            System.Console.Write("Ingrese nuevamente el DNI");
            dni = Console.ReadLine()??""; 
        }
        System.Console.Write("Ingrese nombres completos del solicitante:");
         string nombre= Console.ReadLine()?? ""; 
        while(!Validar_Expediente.ValidarTexto(nombre))
        {
            System.Console.Write("El nombre es obligatorio. Ingresar nombre correctamente");
            nombre = Console.ReadLine() ??""; 
        }
         System.Console.Write("Ingrese apellidos completos del solicitante:");
         string apellido= Console.ReadLine()??""; 
        while(!Validar_Expediente.ValidarTexto(apellido))
        {
            System.Console.Write("El Apellido es obligatorio. Ingresar apellido correctamente");
            apellido = Console.ReadLine()??""; 
        } 
        Console.Write("Ingrese direccion domiciliaria:"); 
         string direccion= Console.ReadLine()??""; 
        while(!Validar_Expediente.ValidarTexto(direccion))
        {
            System.Console.Write("La direcciones obligatoria. Ingresela nuevamente ");
            direccion= Console.ReadLine()??""; 
        }
        System.Console.Write("Ingrese el motivo de la solicitud : ");
         string motivo = Console.ReadLine()??""; 
        while(!Validar_Expediente.ValidarTexto(motivo))
        {
            System.Console.Write("El motivo de la solicitud es obligatoria. Ingresela nuevamente");
            motivo= Console.ReadLine()??""; 
        }
        dnis[contador]= dni; 
        nombres[contador]= nombre.Trim() + " " + apellido.Trim();
        direcciones[contador]=direccion.Trim();
        razones[contador]=motivo.Trim(); 
        codigos[contador]= "EXP-" + (contador + 1 ).ToString("D4"); 

        System.Console.WriteLine("**********EXPEDIENTE REGISTRADO***********");
        System.Console.WriteLine($"CODIGO {codigos[contador]}");
        System.Console.WriteLine($"DNI: {dnis[contador]} ");
        System.Console.WriteLine($"Nombre:{nombres[contador]}");
        System.Console.WriteLine($"Apellido:{apellido}");
        System.Console.WriteLine($"Direccion :{direcciones[contador]}");
        System.Console.WriteLine($"Motivo :{razones[contador]}");
        contador ++; 
    }
}
public class Validar_Expediente
{
    public static  bool ValidarDNI(string dni)
    {
        if(dni.Length !=8)
        {
            return false; 
        }
        foreach(char numero in dni )
        {
            if(numero <'0' || numero > '9')
            {
                return false; 
            }
        }
        return true; 
    }
    public static bool ValidarTexto(string texto)
    {
        return !string.IsNullOrWhiteSpace(texto)&& !texto.Contains('|'); 
    }
}
