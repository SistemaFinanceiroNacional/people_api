public interface ICompanyRepository
{
    public Empresa SearchCompany(Cnpj cnpj);

    public void AddCompany(Empresa empresa);
}