using System;
using System.Collections.Generic;


    public class Person {

        private string name {get; set; }
        private Cpf cpf;
        private DateTime birthday {get; set; }
        private JobSituation jobsituation {get; set; }

        public Person(string name, Cpf cpf, DateTime  birthday, JobSituation jobSituation)
        {
        this.name = name;
        this.cpf = cpf;
        this.birthday = birthday;
        this.jobsituation = jobSituation;
        }

        public void ShowInfo()
        {
        Console.WriteLine("Nome: " + this.name);
        Console.WriteLine("Cpf: " + this.cpf);
        Console.WriteLine("Data de Aniversário: " + this.birthday.ToShortDateString());
        Console.WriteLine("Situação empregaticia: " + this.jobsituation.toString());
        }

        static public Person searchPerson(List<Person> personList, Cpf cpf)
        {
        foreach (Person person in personList)
        {
            if (person.cpf.Equals(cpf))
            {
                return person;
            }
        }
        return null;
        }
        
        public void ChangeJobSituation(Person empregado, Empresa empresa)
        {
            empregado.jobsituation = new Empregado(empresa);
        }

    }