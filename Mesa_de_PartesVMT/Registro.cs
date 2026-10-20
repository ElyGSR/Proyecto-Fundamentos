public class Registro_Expediente
{
    public string Codigo {get; set; }="";
    public string DNI{get; set;}=""; 
    public string Nombre{get; set; }=""; 
    public string Direccion {get; set; }="";
    public string Motivo{ get; set; }="";  
};
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
