namespace Mesa_de_PartesVMT; 

  public static class Registro_Expediente
{
    public static void Registrar_expediente(
         string[]Codigo,
         string[]DNI, 
         string[]Nombre,
         string[]Direccion,
         string[]Motivo, 
         ref int Contador)
    {
        if(Contador >= Codigo.Length)
        {
            System.Console.WriteLine("No hay espacio disponible");
            return; 
        }
        System.Console.WriteLine("Ingrese DNI del solicitante");
        string DNI_Ingresado = Console.ReadLine()?? ""; 
        while(!Validar_Expediente.ValidarDNI(DNI_Ingresado))
        {
            System.Console.WriteLine("El DNI es incorrecto, Debe tener 8 digitos");
            System.Console.Write("Ingrese nuevamente el DNI");
            DNI_Ingresado = Console.ReadLine()??""; 
        }
        System.Console.Write("Ingrese nombres completos del solicitante:");
         string Nombre_Ingresado= Console.ReadLine()?? ""; 
        while(!Validar_Expediente.ValidarTexto(Nombre_Ingresado))
        {
            System.Console.Write("El nombre es obligatorio. Ingresar nombre correctamente");
            Nombre_Ingresado = Console.ReadLine() ??""; 
        }
         System.Console.Write("Ingrese apellidos completos del solicitante:");
         string Apellido_Ingresado= Console.ReadLine()??""; 
        while(!Validar_Expediente.ValidarTexto(Apellido_Ingresado))
        {
            System.Console.Write("El Apellido es obligatorio. Ingresar apellido correctamente");
            Apellido_Ingresado = Console.ReadLine()??""; 
        } 
        Console.Write("Ingrese direccion domiciliaria:"); 
         string Direccion_Ingresada= Console.ReadLine()??""; 
        while(!Validar_Expediente.ValidarTexto(Direccion_Ingresada))
        {
            System.Console.Write("La direcciones obligatoria. Ingresela nuevamente ");
            Direccion_Ingresada= Console.ReadLine()??""; 
        }
        System.Console.Write("Ingrese el motivo de la solicitud : ");
         string Motivo_Ingresado = Console.ReadLine()??""; 
        while(!Validar_Expediente.ValidarTexto(Motivo_Ingresado))
        {
            System.Console.Write("El motivo de la solicitud es obligatoria. Ingresela nuevamente");
            Motivo_Ingresado= Console.ReadLine()??""; 
        }
        DNI[Contador]= DNI_Ingresado; 
        Nombre[Contador]= Nombre_Ingresado.Trim() + " " + Apellido_Ingresado.Trim();
        Direccion[Contador]=Direccion_Ingresada.Trim();
        Motivo[Contador]=Motivo_Ingresado.Trim(); 
        Codigo[Contador]= "EXP-" + (Contador + 1 ).ToString("D4"); 

        System.Console.WriteLine("**********EXPEDIENTE REGISTRADO***********");
        System.Console.WriteLine($"CODIGO {Codigo[Contador]}");
        System.Console.WriteLine($"DNI: {DNI[Contador]} ");
        System.Console.WriteLine($"Nombre:{Nombre[Contador]}");
        System.Console.WriteLine($"Apellido:{Apellido_Ingresado}");
        System.Console.WriteLine($"Direccion :{Direccion[Contador]}");
        System.Console.WriteLine($"Motivo :{Motivo[Contador]}");
        Contador ++; 
    }
}
public class Validar_Expediente
{
    public static  bool ValidarDNI(string DNI)
    {
        if(DNI.Length !=8)
        {
            return false; 
        }
        foreach(char numero in DNI )
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
