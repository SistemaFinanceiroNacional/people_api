public class PersonRepository : IPersonRepository
{

    private List<Person> people = new List<Person>();
    public Person SearchPerson(Cpf cpf)
    {

        foreach(Person person in people)
        {
            if(person.cpf.Equals(cpf))
            {
                return person;
            }
        }

        return null;
    }

    public void AddPerson(Person person)
    {
        this.people.Add(person);
    }
}