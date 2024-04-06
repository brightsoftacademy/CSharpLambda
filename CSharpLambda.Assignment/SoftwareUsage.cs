public class SoftwareUsage : ISoftwareUsage
{
    public bool MaiorDeIdade(Profile profile)
    {
        throw new NotImplementedException();
    }

    public string Resumo(Profile profile)
    {
        throw new NotImplementedException();
    }
}

public interface ISoftwareUsage
{
    string Resumo(Profile profile);
    bool MaiorDeIdade(Profile profile);
}

public class Profile
{
    public int Idade { get; set; }
    public string Nome { get; set; }
    public string Endereço { get; set; }
}