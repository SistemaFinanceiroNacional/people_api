public class Empresario : JobSituation
{
    private Empresa empresa { get; set; }

    public Empresario(Empresa empresa)
    {
        this.empresa = empresa;
    }

    public string toString()
    {
        return "Dono da empresa" + empresa;
    }
}