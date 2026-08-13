namespace Core.Entidades;

public class Cliente
{
    public int idCliente {get; set;}
    public int dni {get; set;}
    public string nombre {get; set;}
    public string apellido {get; set;}
    public DateOnly nacimiento {get; set;}
    public string correo {get; set;}
    
    public Cliente (int dni,string Nombre, string Apellido, DateOnly Nacimiento)
    {
        this.dni = dni;
        nombre = Nombre;
        apellido = Apellido;
        nacimiento = Nacimiento;
    }
}