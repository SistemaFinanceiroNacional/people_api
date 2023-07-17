

    public class Empregado : JobSituation
{
    private Empresa empresa { get; set; }

    public Empregado(Empresa empresa)
    {
        this.empresa = empresa;
    }

    public string toString()
    {
        return "Funcionario da " + empresa;
    }
}
