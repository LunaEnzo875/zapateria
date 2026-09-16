namespace Core.Entidades;

public class Cliente
{
    public int idCliente { get; set; }
    public int dni { get; set; }
    public string nombre { get; set; } = string.Empty;
    public string apellido { get; set; } = string.Empty;
    public DateTime nacimiento { get; set; }
    public string correo { get; set; } = string.Empty;

    public Cliente()
    {
    }

    public Cliente(int dni, string Nombre, string Apellido, DateTime Nacimiento)
    {
        this.dni = dni;
        this.nombre = Nombre;
        this.apellido = Apellido;
        this.nacimiento = Nacimiento;
    }
}