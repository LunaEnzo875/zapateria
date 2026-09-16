namespace  Core.Dto;

public class ModeloDto
{
    public int idModelo { get; set; }
    public int idFabricante { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public int idPaisOrigen { get; set; }
}