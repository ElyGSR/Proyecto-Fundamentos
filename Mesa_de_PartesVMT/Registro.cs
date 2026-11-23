namespace Mesa_de_PartesVMT; 

  public static class Registro
{
    public static void RegistrarExpediente(
        
         string[]codigos,
         string[]documentos,
         string[]tiposDocumentos, 
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

        System.Console.WriteLine("Seleccione el tipo de Documento: ");
        Console.WriteLine("1:DNI");
        Console.WriteLine("2:Carnet de extrangeria");
        Console.Write("seleccione una opcion: "); 
        string tipos = Console.ReadLine()?? ""; 

        while(tipos!= "1" && tipos != "2")
        {
            Console.WriteLine("Opcion incorrecta ");
            Console.Write("Seleccione 1  o 2 "); 
            tipos = Console.ReadLine()??"";
        }
        string tiposDocumento = tipos== "1" ? "DNI" : "Carnet de extrangeria";
        Console.Write("Ingrese el numwero de documento: "); 
        string documento= Console.ReadLine()??"";

        while(!Validar_Expediente.ValidarDocumentos(tipos, documento)) 
        {
            System.Console.WriteLine("El numero de documento es incorrecto");
            System.Console.Write("Ingrese nuevamente el tipo de documento: ");
            documento = Console.ReadLine()??""; 
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
        documentos[contador]= documento; 
        tiposDocumentos[contador]= tiposDocumento; 
        nombres[contador]= nombre.Trim() + " " + apellido.Trim();
        direcciones[contador]=direccion.Trim();
        razones[contador]=motivo.Trim(); 
        codigos[contador]= "EXP-" + (contador + 1 ).ToString("D4"); 

        System.Console.WriteLine("**********EXPEDIENTE REGISTRADO***********");
        System.Console.WriteLine($"CODIGO {codigos[contador]}");
        System.Console.WriteLine($"TIPO DE DOCUMENTO: {tiposDocumentos[contador]} ");
        Console.WriteLine($"NUMERO DE DOCUMENTO: {documentos[contador]}");
        System.Console.WriteLine($"Nombre:{nombres[contador]}");
        System.Console.WriteLine($"Apellido:{apellido}");
        System.Console.WriteLine($"Direccion :{direcciones[contador]}");
        System.Console.WriteLine($"Motivo :{razones[contador]}");
        contador ++; 
    }
}
public class Validar_Expediente
{
    public static  bool ValidarDocumentos(string tipos, string documentos)
    {
        if(tipos == "1")
        {
            return documentos.Length == 8 && 
            documentos.All(char.IsDigit); 
        }
        else if(tipos == "2")
        {
            return documentos.Length >= 9 && 
                   documentos.Length <=12 &&
                   documentos.All(char.IsDigit);
        }
        else
        {
            return false; 
        }
    }
    
    public static bool ValidarTexto(string texto)
    {
        return !string.IsNullOrWhiteSpace(texto)&& !texto.Contains('|'); 
    }
}
