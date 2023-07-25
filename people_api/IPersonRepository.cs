public interface IPersonRepository
{
    public Person SearchPerson(Cpf cpf);

    public void AddPerson(Person person);
    
}
