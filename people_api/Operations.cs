using System;
using System.Collections.Generic;

class Operations{
    static List<Person> personList = new List<Person>();
    static List<Empresa> empresas = new List<Empresa>();
    static void Main(string[] args)
    {

        Console.WriteLine("Que tipo de operação você gostaria de fazer:\nPessoa física: 1\nPessoa Juridica: 2\nSair: 3");
        int option = int.Parse(Console.ReadLine());

        if(option == 1){

           MenuOne(); 
         
        }else if(option == 2){

            MenuTwo();

        }else if(option == 3)
        {
            Console.WriteLine("Obrigado e volte sempre!");

        }else
        {
            Console.WriteLine("Opção invalida");
        }
         
            
    }

    static void MenuOne()
    {
        bool run = true;

        while(run)
            {
                Console.WriteLine("O que gostaria de fazer:\nListar dados de uma pessoa: 1\nRegistrar uma nova pessoa: 2\nSair: 3");
                int choice = int.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Digite o Cpf da pessoa:");
                        Cpf personCpf = Cpf.makeCpf(Console.ReadLine());
                        Person wantedPerson = Person.searchPerson(personList, personCpf);

                        if (wantedPerson != null)
                        {
                            wantedPerson.ShowInfo();
                        }else
                        {
                            Console.WriteLine("Pessoa não encontrada!");
                        }

                        break;
                    case 2:
                        Console.WriteLine("Digite o seu nome: ");
                        string name = Console.ReadLine();

                        Console.WriteLine("Digite o seu cpf: ");
                        Cpf cpf = Cpf.makeCpf(Console.ReadLine());

                        Console.WriteLine("Digite o dia do seu aniversário: ");
                        int day = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o mês do seu aniversário: ");
                        int month = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o ano do seu aniversário: ");
                        int year = int.Parse(Console.ReadLine());

                        Console.WriteLine("Qual a sua situação empregaticia: \n1 = Empregado\n2 = Empresario\n3 = Desempregado");
                        string situation = Console.ReadLine();
                        JobSituation jobSituation;
                        
                        if(situation.Equals(1))
                        {
                            Console.WriteLine("Qual o Cnpj da empresa que você trabalha:\n");
                            Cnpj cnpj = Cnpj.makeCnpj(Console.ReadLine());
                            Empresa empresa = Empresa.searchEmpresa(cnpj, empresas);
                            
                            if(empresa != null)
                            {
                                jobSituation = new Empregado(empresa);
                            }else
                                {
                                    Console.WriteLine("Empresa não encontrada");
                                    break;
                                }
                        }else if(situation.Equals(2))
                        {
                            Console.WriteLine("Qual o Cnpj da sua empresa:\n");
                            Cnpj cnpj = Cnpj.makeCnpj(Console.ReadLine());
                            Empresa empresa = Empresa.searchEmpresa(cnpj, empresas);

                            if (empresa != null)
                            {
                                jobSituation = new Empregado(empresa);
                            }else
                                {
                                    Console.WriteLine("Empresa não encontrada");
                                    break;
                                }
                        }else if(situation.Equals(3))
                            {
                                jobSituation = new Desempregado();
                            }else
                             {
                                Console.WriteLine("Opção invalida!");
                                break;
                             }

                        personList.Add(new Person(name, cpf, new DateTime(year, month, day), jobSituation));
                        Console.WriteLine("Pessoa adicionada com sucesso!");

                        break;
                    case 3:

                        Console.WriteLine("Obrigado e volte sempre!");
                        run = false;
                        break;

                    default:

                        Console.WriteLine("Opção invalida, tente outra");
                        break;
                }
            }

    }

    static void MenuTwo()
    {
        bool run = true;

        while(run)
            {
                Console.WriteLine("O que gostaria de fazer:\nListar dados de uma empresa: 1\nRegistrar uma nova empresa: 2\nRegistrar um novo funcionário: 3\nSair: 4");
                int choice = int.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Digite o CNPJ da empresa:\n");
                        Cnpj cnpj = Cnpj.makeCnpj(Console.ReadLine());
                        Empresa foundedCommpany = Empresa.searchEmpresa(cnpj, empresas);
                        
                        if(foundedCommpany != null)
                        {
                            foundedCommpany.ShowInfo();
                        }else
                        {
                            Console.WriteLine("Empresa não encontrada!\n");
                        }

                        break;
                    case 2:
                        Console.WriteLine("Digite o nome da empresa");
                        string nome = Console.ReadLine();

                        Console.WriteLine("Digite o CNPJ da empresa");
                        Cnpj newCnpj = Cnpj.makeCnpj(Console.ReadLine());

                        Console.WriteLine("Digite o CPF do dono da empresa");
                        Cpf cpf = Cpf.makeCpf(Console.ReadLine());
                        Person dono = Person.searchPerson(personList,cpf);
                        if(dono == null)
                        {
                            Console.WriteLine("A pessoa não está registrada no sistema\n");
                            break;
                        }
                        empresas.Add(new Empresa(nome, newCnpj, dono, new List<Person>()));
                        Console.WriteLine("Empresa criada com sucesso!\n");


                        break;
                    case 3:
                        Console.WriteLine("Digite o CNPJ da empresa:\n");
                        Cnpj cnpj1 = Cnpj.makeCnpj(Console.ReadLine());
                        Empresa empresa = Empresa.searchEmpresa(cnpj1, empresas);
                        if(empresa == null)
                        {
                            Console.WriteLine("Empresa não encontrada!\n");
                            break;
                        }

                        Console.WriteLine("Digite o CPF do novo funcionário:\n");
                        Cpf cpf1 = Cpf.makeCpf(Console.ReadLine());
                        Person person = Person.searchPerson(personList, cpf1);
                        if(person == null)
                        {
                            Console.WriteLine("Pessoa não encontrada!\n");
                            break;
                        }

                        empresa.NewEmployee(person);
                        Console.WriteLine("Funcionário cadastrado com sucesso!\n");
                                               
                        break;

                    case 4:

                        Console.WriteLine("Obrigado e volte sempre!");
                        run = false;
                        break;

                    default:

                        Console.WriteLine("Opção invalida, tente outra");
                        break;
                }
            }
        
    }

}