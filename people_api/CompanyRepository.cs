public class CompanyRepository : ICompanyRepository
{
    private List<Empresa> companies = new List<Empresa>();
    public Empresa SearchCompany(Cnpj cnpj)
    {
        foreach (Empresa company in this.companies)
        {
            if(company.cnpj.Equals(cnpj))
            {
                return company;
            }
        }
        return null;
    }

    public void AddCompany(Empresa empresa)
    {
        this.companies.Add(empresa);
    }

}
