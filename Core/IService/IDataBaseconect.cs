namespace  Core.IService;

public interface IDataBaseConnectionService
{
    string GetConnectionRootString();
    string GetConnectionUserString(string rol);
}