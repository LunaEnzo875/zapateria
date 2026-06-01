namespace calzados;

public class Cliente
{
    public int dni {get; set;}
    public string nombre {get; set;}
    public string apellido {get; set;}
    public DateOnly nacimiento {get; set;}
    public string correo {get; set;}
    
    public Cliente (int dni,string nombre, string apellido, DateOnly nacimiento)
    {
        this.dni = dni;
        nombre = nombre;
        apellido = apellido;
        nacimiento = nacimiento;
    }
}