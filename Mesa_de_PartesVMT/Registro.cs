public class Registro_Expediente
{
    public string Codigo {get; set; }="";
    public string DNI{get; set;}=""; 
    public string Nombre{get; set; }=""; 
    public string Apellido{get; set; }="";
    public string Direccion {get; set; }="";
    public string Motivo{ get; set; }="";  
    public Registro_Expediente()
    {
        Codigo= "EXP-001"; 
        Validar_Expediente validar= new Validar_Expediente(); 

        System.Console.WriteLine("Ingrese DNI del solicitante");
        DNI = Console.ReadLine() ; 
        while(!validar.ValidarDNI(DNI))
        {
            System.Console.WriteLine("El DNI es incorrecto, Debe tener 8 digitos");
            System.Console.Write("Ingrese nuevamente el DNI");
            DNI = Console.ReadLine(); 
        }
        System.Console.Write("Ingrese nombres completos del solicitante:");
        Nombre= Console.ReadLine(); 
        while(string.IsNullOrWhiteSpace(Nombre))
        {
            System.Console.Write("El nombre es obligatorio. Ingresar nombre correctamente");
            Nombre = Console.ReadLine(); 
        }
         System.Console.Write("Ingrese apellidos completos del solicitante:");
        Apellido= Console.ReadLine(); 
        while(string.IsNullOrWhiteSpace(Apellido))
        {
            System.Console.Write("El Apellido es obligatorio. Ingresar apellido correctamente");
            Apellido = Console.ReadLine(); 
        } 
        Console.Write("Ingrese direccion domiciliaria:"); 
        Direccion = Console.ReadLine(); 
        while(string.IsNullOrWhiteSpace(Direccion))
        {
            System.Console.Write("La direcciones obligatoria. Ingresela nuevamente ");
            Direccion= Console.ReadLine(); 
        }
        System.Console.Write("Ingrese el motivo de la solicitud : ");
        Motivo = Console.ReadLine(); 
        while(string.IsNullOrWhiteSpace(Motivo))
        {
            System.Console.Write("El motivo de la solicitud es obligatoria. Ingresela nuevamente");
            Motivo= Console.ReadLine(); 
        }
        System.Console.WriteLine("**********EXPEDIENTE REGISTRADO***********");
        System.Console.WriteLine($"CODIGO {Codigo}");
        System.Console.WriteLine($"DNI: {DNI} ");
        System.Console.WriteLine($"Nombre:{Nombre}");
        System.Console.WriteLine($"Apellido:{Apellido}");
        System.Console.WriteLine($"Direccion :{Direccion}");
        System.Console.WriteLine($"Motivo :{Motivo}");
    }
}
public class Validar_Expediente

{
    public bool ValidarDNI(string DNI)
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
}
