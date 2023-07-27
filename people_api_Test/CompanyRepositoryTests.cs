
namespace people_api_Test
{
    public class CompanyRepositoryTests
    {
        Cnpj cnpj = Cnpj.makeCnpj("79592112000139");
        


        [Test]
        public void Test1()
        {
            CompanyRepository repository = new CompanyRepository();
            Assert.IsNull(repository.SearchCompany(cnpj));
        }

        [Test]
        public void Test2()
        {
            CompanyRepository repository = new CompanyRepository();
            Person personOne = new Person("ryan", Cpf.makeCpf("89507632069"), new DateTime(2002, 01, 01), new Desempregado());
            Empresa company = new Empresa("sonyA", Cnpj.makeCnpj("54607642000182"), personOne, new List<Person>());
            repository.AddCompany(company);

            Assert.IsNotNull(repository.SearchCompany(Cnpj.makeCnpj("54607642000182")));
        }
    }
}
