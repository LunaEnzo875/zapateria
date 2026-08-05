namespace ZapatosRepo;

public class RepoColor
{
    private static readonly string _Color
        = "SELECT * FROM Color";

    public IEnumerable<ColorDto> GetColor() => _conexion.Query<ColorDto>(_Color);
}