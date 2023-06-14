using System;
using System.Collections.Generic;


    public class Person {

        private string name {get; set; }
        private string cpf {get; set; }
        private DateTime birthday {get; set; }

        public Person(string name, string cpf, DateTime  birthday)
        {
        this.name = name;
        this.cpf = cpf;
        this.birthday = birthday;
        }

        public void ShowInfo()
        {
        Console.WriteLine("Nome: " + this.name);
        Console.WriteLine("Cpf: " + this.cpf);
        Console.WriteLine("Data de Aniversário: " + this.birthday.ToShortDateString());
        }

        static public Person searchPerson(List<Person> personList, string cpf)
        {
        foreach (Person person in personList)
        {
            if (person.cpf == cpf )
            {
                return person;
            }
        }
        return null;
        }

    }